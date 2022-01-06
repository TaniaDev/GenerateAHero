using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public class HostedService2 : BackgroundService
{
    private readonly HeroGenerator heroGenerator;
    private readonly ILogger<HostedService2> logger;

    public HostedService2(
        HeroGenerator heroGenerator,
        ILogger<HostedService2> logger
    )
    {
        this.heroGenerator = heroGenerator;
        this.logger = logger;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            this.logger.LogInformation("Generating a hero: {hero}", heroGenerator.Generate());
            await Task.Delay(3000);
        }
    }
}
