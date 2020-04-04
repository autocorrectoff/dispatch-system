# dispatch-system

create sql server image instance
*docker run --name dispatch_system -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=admin_pass' -e 'MSSQL_PID=Express' -p 1433:1433 -v dispatch_system_data:/var/opt/mssql/data -v dispatch_system_log:/var/opt/mssql/log -d mcr.microsoft.com/mssql/server:2017-latest-ubuntu*