using Asp.Versioning;
using Asp.Versioning.ApiExplorer;
using Asp.Versioning.Conventions;
using Serilog;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc;
using HelmerDemo.WebShop.Presentation.Middleware;
using HelmerDemo.WebShop.Presentation.Helpers;
using HelmerDemo.WebShop.Presentation.Models;
using HelmerDemo.WebShop.Application.CustomerService;
using HelmerDemo.WebShop.Infrastructure;
using Microsoft.EntityFrameworkCore;
using HelmerDemo.WebShop.Domain.CustomerModel;
using HelmerDemo.WebShop.Infrastructure.CustomerModel;

var builder = WebApplication.CreateBuilder(args);

AddServices(builder);
ConfigureRequestPipeline(builder.Build());


// Add Services to the container
static void AddServices(WebApplicationBuilder builder)
{
    builder.Services.Configure<HeaderSettings>(options => builder.Configuration.GetSection("HeaderSettings").Bind(options));
    builder.Services.AddTransient<ApiSecurityMiddleware>();

    if (IsDevelopment())
    {
        builder.Services.AddTransient<WebSecurityMiddleware>();
    }
    builder.Services.AddControllers();

    // Services
    builder.Services.AddScoped<ICustomerService, CustomerService>();
    builder.Services.AddScoped<ICustomerAggregate, CustomerAggregate>();
    builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

	// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

	builder.Services.AddApiVersioning(options =>
		{
			options.DefaultApiVersion = new ApiVersion(1, 0);
			options.AssumeDefaultVersionWhenUnspecified = true;
			options.ApiVersionReader = new UrlSegmentApiVersionReader();
		})
		.AddMvc(options =>
			{
				options.Conventions.Add(new VersionByNamespaceConvention());
			}
		)
		.AddApiExplorer(setup =>
		{
			setup.GroupNameFormat = "'v'VVV";
			setup.SubstituteApiVersionInUrl = true;
		});

	builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();

    builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));
    builder.Services.AddDbContext<CustomerDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CustomerDatabase")));
}

// Configure the HTTP request pipeline
static void ConfigureRequestPipeline(WebApplication app)
{
    var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            foreach (var description in apiVersionDescriptionProvider.ApiVersionDescriptions)
            {
                options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
                    description.GroupName.ToUpperInvariant());
            }
        });
    }
    
    app.UseMiddleware<ApiSecurityMiddleware>();

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}

static bool IsDevelopment()
{
    var aspEnvironment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

    return string.IsNullOrEmpty(aspEnvironment) ? false : aspEnvironment.ToLowerInvariant().Equals("development");
}