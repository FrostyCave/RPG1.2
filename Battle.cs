class Battle
{
    public static void IsHeroDead(Hero hero)
    {
        if (hero.health <= 0)
        {
            Console.Clear();
            Console.WriteLine("You have been killed in battle and died like a hero!");
            Console.WriteLine("Maybe next time you will be more succesfull!");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
    public static void PrintTheStats(Person person1, Person person2)
    {
        person1.PrintStats();
        Console.WriteLine("");
        person2.PrintStats();
        Console.WriteLine("");
    }

    public static void WithBandit(Hero hero, Bandit bandit)
    {
        while (bandit.health > 0 && hero.health > 0)
        {
            PrintTheStats(bandit, hero);

            hero.YourTurn(hero.Choice(), bandit);

            if (bandit.health > 0)
            {
                bandit.BanditTurn(bandit.EChoice(), hero);
                IsHeroDead(hero);
            }

        }

        Console.WriteLine("{0} was killed!", bandit.name);
        Console.ReadLine();
        Console.Clear();
    }

    public static void WithMage(Hero hero, Mage Mage)
    {
        while (Mage.health > 0 && hero.health > 0)
        {
            PrintTheStats(Mage, hero);

            hero.YourTurn(hero.Choice(), Mage);

            if (Mage.health > 0)
            {
                Mage.MageTurn(Mage.EChoice(), hero);
                IsHeroDead(hero);
            }
        }

        Console.WriteLine("{0} was killed!", Mage.name);
        Console.ReadLine();
        Console.Clear();
    }

    public static void WithDragon(Hero hero, Dragon dragon)
    {
        while (dragon.health > 0 && hero.health > 0)
        {
            PrintTheStats(dragon, hero);

            hero.YourTurn(hero.Choice(), dragon);

            if (dragon.health > 0)
            {
                dragon.DragonTurn(dragon.EChoice(), hero);
                IsHeroDead(hero);
            }
        }

        Console.WriteLine("{0} was killed !", dragon.name);
        Console.ReadLine();
        Console.Clear();
    }
}