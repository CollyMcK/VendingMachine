
namespace CMcK_Vending_Machine
{
    // class for the constants - sealed so the class cannot be inherited
    public sealed class Constants
    {
        // define some const strings for example products the Vending machine may hold
        public const string Coke = "Coke";

        public const string FantaOrange = "Fanta Orange";

        public const string FantaLemon = "Fanta Lemon";

        public const string Lilt = "Lilt";

        public const string Sprite = "Sprite";

        public const string DietCoke = "Diet Coke";

        // define of ints for the number of each coins our machine has on start up
        // some assumptions made here as too the amount of 2p, and 20p coins and no £1 or £2 coins coded for
        public static int OnePenceCount = 100;

        public static int TwoPenceCount = 100;

        public static int FivePenceCount = 50;

        public static int TenPenceCount = 50;

        public static int TwentyPenceCount = 20;

        public static int FiftyPenceCount = 20;
    }
}
