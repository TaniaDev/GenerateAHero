public class HeroGenerator
{
    private readonly NameGenerator nameGenerator;
    private readonly SuperpowerGenerator superpowerGenerator;
    private readonly WeaponGenerator weaponGenerator;
    public HeroGenerator(
        NameGenerator nameGenerator,
        SuperpowerGenerator superpowerGenerator,
        WeaponGenerator weaponGenerator
    )
    {
        this.nameGenerator = nameGenerator;
        this.superpowerGenerator = superpowerGenerator;
        this.weaponGenerator = weaponGenerator;
        this.Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public Hero Generate()
    {
        var name = this.nameGenerator.Generate();
        var superpower = this.superpowerGenerator.Generate();
        var weapon = this.weaponGenerator.Generate();
        var hero = new Hero(name, superpower, weapon);
        return hero;
    }
}
