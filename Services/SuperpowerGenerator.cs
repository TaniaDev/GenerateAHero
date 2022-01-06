public class SuperpowerGenerator
{
    private static string[] SuperpowerNames = new string[]
    {
        "Super velocidade",
        "Super força",
        "Ler mentes",
        "Imortalidade",
        "Uso de chakra",
        "Ser kriptoniano",
        "Regeneração celular",
        "Manipulação dos elementos",
        "Magia",
        "Telecinese",
        "Metamorfo"

    };

    private readonly Random random;
    public SuperpowerGenerator(Random random)
    {
        this.random = random;
    }

    public string Generate()
    {
        var index = this.random.Next(0, SuperpowerNames.Length);
        return SuperpowerNames[index];
    }
}
