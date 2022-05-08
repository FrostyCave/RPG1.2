public class Enemy : Person
{
    public int numOfAttack;

    public Enemy(string _name, int _attack, int _health)
        : base(_name, _attack, _health)
    {
    }

    // Battle methods -----------------------------------------

    public int EChoice()
    {
        int eChoice;
        Random ran = new Random();
        eChoice = ran.Next(1, numOfAttack + 1);
        return eChoice;
    }
}

public class Bandit : Enemy
{
    public Bandit(string _name, int _attack, int _health)
        : base(_name, _attack, _health)
    {
        numOfAttack = 2;
    }

    //  Battle methods ---------------------------------------------

    public void Steal(Hero target)
    {
        target.health -= attack + 2;
    }

    public void BanditTurn(int choice, Hero target)
    {
        if (choice == 1)
        {
            NormAttack(target);
            Console.WriteLine("Bandit whacked you!");

        }

        if (choice == 2)
        {
            Steal(target);
            Console.WriteLine("Bandit stole from you!");

        }

        Console.ReadLine();
        Console.Clear();
    }
}

public class Mage : Enemy
{
    public Mage(string _name, int _attack, int _health)
        : base(_name, _attack, _health)
    {
        numOfAttack = 3;
    }

    // Battle methods -------------------------------------------

    public void Burn(Hero target)
    {
        target.health -= attack + 5;
    }

    public void Poison(Hero target)
    {
        target.health -= attack + 2;
    }

    public void MageTurn(int choice, Hero target)
    {
        if (choice == 1)
        {
            NormAttack(target);
            Console.WriteLine("Mage stuned you!");
        }

        if (choice == 2)
        {
            Burn(target);
            Console.WriteLine("Mage burned you!");
        }

        if (choice == 3)
        {
            Poison(target);
            Console.WriteLine("Mage poisoned you!");
        }

        Console.ReadLine();
        Console.Clear();
    }
}

public class Dragon : Enemy
{
    public int armor;

    public Dragon(string _name, int _attack, int _health, int _armor)
        : base(_name, _attack, _health)
    {
        numOfAttack = 4;
        armor = _armor;
    }

    // Battle methods ------------------------------------------------------------

    public void FireBreath(Hero target)
    {
        target.health -= attack * 2;
    }

    public void Claw(Hero target)
    {
        target.health -= attack + 3;
    }

    public void Bite(Hero target)
    {
        target.health -= attack + 4;
    }

    public void DragonTurn(int choice, Hero target)
    {
        if (choice == 1)
        {
            NormAttack(target);
            Console.WriteLine("Dragon bite you!");
        }

        if (choice == 2)
        {
            FireBreath(target);
            Console.WriteLine("Dragon burned you to a crisp!");
        }

        if (choice == 3)
        {
            Claw(target);
            Console.WriteLine("Dragon clawed you to pices!");
        }

        if (choice == 4)
        {
            Bite(target);
            Console.WriteLine("Dragon eat you!");
        }

        Console.ReadLine();
        Console.Clear();
    }
}