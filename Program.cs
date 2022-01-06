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
            .AddSingleton<HeroGenerator>()
            .AddSingleton<NameGenerator>()
            .AddSingleton<SuperpowerGenerator>()
            .AddSingleton<WeaponGenerator>()
            .AddSingleton(new Random(1));
    })
    .Build();

host.Run();
