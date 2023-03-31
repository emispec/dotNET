//Instalar la libreria: desde nuget buscar el paquete y por CLI -> dotnet add package Microsoft.Extensions.DependencyInjection --version 8.0.0-preview.2.23128.3
using Microsoft.Extensions.DependencyInjection;
//dotnet add package Microsoft.Extensions.Hosting --version 8.0.0-preview.2.23128.3
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args).ConfigureServices((_, services) => services
.AddTransient<ITransientOperation, DefaultOperation>()
.AddScoped<IScopedOperation, DefaultOperation>()
.AddSingleton<ISingletonOperation, DefaultOperation>()
.AddTransient<OperationLogger>()).Build();

EjemploScopes(host.Services,"Scope 1" );
EjemploScopes(host.Services, "Scope 2");

await host.StartAsync(); //inicio asincrono

static void EjemploScopes(IServiceProvider services, string scope)
{
    using IserviceScope serviceScope = services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;

    OperationLogger logger = provider.GetRequiredService<OperationLogger>();
    logger.LogOperations($"{scope}: -- ejecutando... GetRequiredService<OperationLogger> ");

    System.Console.WriteLine();
/*
    logger = provider.GetRequiredService<OperationLogger>();
    logger.LogOperations($"{scope}: -- ejecutando... GetRequiredService<OperationLogger> ");
    
    System.Console.WriteLine();
*/
}