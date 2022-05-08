public class Person
{
    public string name;
    public int attack;
    public int health;

    public Person(string _name, int _attack, int _health)
    {
        name = _name;
        attack = _attack;
        health = _health;
    }

    public void PrintStats()
    {
        Console.WriteLine("{0} stats:", name);
        Console.WriteLine("");
        Console.WriteLine("Attack value is: {0}", attack);
        Console.WriteLine("Health value is: {0}", health);
    }

    public void NormAttack(Person target)
    {
        target.health -= attack;
    }
}