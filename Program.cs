using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var host = Host
    .CreateDefaultBuilder()
    .ConfigureLogging(logging =>
    {
        logging.AddConsole();
    })
    .ConfigureServices((host, services) =>
    {
        services
            .AddHostedService<HostedService1>()
            .AddHostedService<HostedService2>()
            .AddTransient<HeroGenerator>()
            .AddTransient<NameGenerator>()
            .AddTransient<SuperpowerGenerator>()
            .AddTransient<WeaponGenerator>()
            .AddTransient<Random>((services) => new Random(0));
    })
    .Build();

host.Run();
