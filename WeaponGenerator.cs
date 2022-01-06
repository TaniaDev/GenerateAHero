public class WeaponGenerator
{
    private static string[] NameWeapons = new string[]
    {
        "Arco-e-flecha",
        "Chicote",
        "Pistola",
        "Adaga",
        "Foice",
        "Escudo",
        "Manoplas",
        "Escopeta",
        "Varinha mágica",
        "Katana",
        "Marreta"

    };
    private readonly Random random;
    public WeaponGenerator(Random random)
    {
        this.random = random;
    }

    public string Generate()
    {
        int weaponIndex = this.random.Next(0, NameWeapons.Length);
        return NameWeapons[weaponIndex];
    }
}
