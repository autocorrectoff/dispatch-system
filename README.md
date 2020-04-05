# dispatch-system
  
used techs: .NET Core 3.1.201, Entity Framework 3.1.3, Microsoft SQL Server 2017, Visual Studio 2019

to quicky set up sql server locally, create sql server image instance  
*docker run --name dispatch_system -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=admin_pass' -e 'MSSQL_PID=Express' -p 1433:1433 -v dispatch_system_data:/var/opt/mssql/data -v dispatch_system_log:/var/opt/mssql/log -d mcr.microsoft.com/mssql/server:2017-latest-ubuntu*

to create database  
*create database dispatch_system_db*

to run the migrations from project root using dotnet cli  
*dotnet ef database update*