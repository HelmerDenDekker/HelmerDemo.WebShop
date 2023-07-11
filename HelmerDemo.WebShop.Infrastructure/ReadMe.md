# Working with EF Core

Open the package manager console. Make sure the "Default project" is HelmerDemo.Webshop.Infrastructure

## Create migration
Add-Migration <TheMigrationName> -StartupProject HelmerDemo.WebShop.Presentation

## Update database with specific migration
Update-database <TheMigrationName>  -StartupProject HelmerDemo.WebShop.Presentation

## Create SQL scripts from migration a to migration b
Script-Migration -From <Migration a> -To <Migration a> -Context <YourDbContext> -StartupProject HelmerDemo.WebShop.Presentation -Output "HelmerDemo.WebShop.Infrastructure\Scripts\<ScriptName>.sql"
