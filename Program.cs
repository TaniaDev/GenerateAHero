using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services
    .AddTransient<NameGenerator>()
    .AddTransient<SuperpowerGenerator>()
    .AddTransient<WeaponGenerator>()
    .AddScoped<HeroGenerator>()
    .AddSingleton<Random>(new Random(0));

var provider = services.BuildServiceProvider();

var scope1 = provider.CreateScope();
var scope2 = provider.CreateScope();

Console.WriteLine(scope1.ServiceProvider.GetRequiredService<HeroGenerator>().Id);
Console.WriteLine(scope1.ServiceProvider.GetRequiredService<HeroGenerator>().Id);
Console.WriteLine(scope2.ServiceProvider.GetRequiredService<HeroGenerator>().Id);
Console.WriteLine(scope2.ServiceProvider.GetRequiredService<HeroGenerator>().Id);

var heroGenerator = provider.GetRequiredService<HeroGenerator>();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(heroGenerator.Generate());
}
