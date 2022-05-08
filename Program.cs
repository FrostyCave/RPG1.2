class Program
{
    static void Main(string[] args)
    {
        Hero Yakata = new Hero("Yakata", 3, 15);

        Bandit Keith = new Bandit("Bandit Keith", 1, 5);
        Bandit Ben = new Bandit("Bandit Ben", 2, 8);

        Mage Olaf = new Mage("Mage Olaf", 3, 12);
        Mage Seth = new Mage("Mage Seth", 5, 15);

        Dragon BlueDrag = new Dragon("Blue Dragon", 7, 20, 2);
        Dragon RedDrag = new Dragon("Red Dragon", 8, 20, 3);
        Dragon BlackDrag = new Dragon("Black Dragon", 10, 25, 4);

        Story.BeforeBandits();
        Battle.WithBandit(Yakata, Keith);
        Battle.WithBandit(Yakata, Ben);

        Yakata.LevelUp();

        Story.BeforeMages();
        Battle.WithMage(Yakata, Olaf);
        Battle.WithMage(Yakata, Seth);

        Yakata.LevelUp();

        Story.BeforeDragons();
        Battle.WithDragon(Yakata, BlueDrag);
        Battle.WithDragon(Yakata, RedDrag);
        Battle.WithDragon(Yakata, BlackDrag);

        Story.TheEnd();
    }
}