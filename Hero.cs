public class Hero
{
    public Hero(string name, string superpower, string weapon)
    {
        this.Name = name;
        this.Superpower = superpower;
        this.Weapon = weapon;
    }

    public string Name { get; set; }

    public string Superpower { get; set; }

    public string Weapon { get; set; }

    public override string ToString()
    {
        return $"({this.Name}, {this.Superpower}, {this.Weapon})";
    }
}
