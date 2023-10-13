namespace OOParv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion1 = new Lion("DjungelsKonung", 18, "orange-brown", true);

            lion1.MakeSound();
            lion1.DjungleKing();

            Console.WriteLine();

            Fish fish1 = new Fish("Nemo", 5, "Orange", false, true);

            fish1.MakeSound();
            fish1.swimming();

            Console.WriteLine();

            Cheetah cheetah1 = new Cheetah("MrBolt", 25, "golden yellow to pale orange");

            cheetah1.Sprinting();
            cheetah1.MakeSound();
            cheetah1.MythAboutCats();

            Console.WriteLine();

            Dog dog1 = new Dog("Pluto", 10, "black and white", true);

            dog1.SearchingForBone();
            dog1.makeSound();


        }
    }
}

