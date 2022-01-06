public class NameGenerator
{
    private static string[] FirstNames = new string[]
    {
        "Super",
        "Homem",
        "Mulher",
        "Incrível",
        "Pequeno",
        "Grande"
    };

    private static string[] SecondNames = new string[]
    {
        "Aranha",
        "Gato",
        "Aço",
        "Maravilha",
        "Jacaré",
        "Formiga",
        "Estudante",
        "Dentista",
        "Selvagem",
        "Beija-Flor",
        "Chama",
        "Lápis",
        "Laranja",
        "Tempestade",
        "Saiyajin"
    };
    private readonly Random random;
    public NameGenerator(Random random)
    {
        this.random = random;
    }

    public string Generate()
    {
        var fisrtIndex = this.random.Next(0, FirstNames.Length);
        var secondIndex = this.random.Next(0, SecondNames.Length);
        return $"{FirstNames[fisrtIndex]}-{SecondNames[secondIndex]}";
    }
}
