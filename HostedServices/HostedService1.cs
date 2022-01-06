using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
public class HostedService1 : IHostedService
{
    private readonly HeroGenerator heroGenerator;
    private readonly ILogger<HostedService1> logger;

    public HostedService1(
        HeroGenerator heroGenerator,
        ILogger<HostedService1> logger)
    {
        this.heroGenerator = heroGenerator;
        this.logger = logger;
    }
    public Task StartAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation("Starting HostedService1");
        logger.LogInformation("New Hero: {hero}", heroGenerator.Generate());
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation("Stopping HostedService1");
        return Task.CompletedTask;
    }
}
