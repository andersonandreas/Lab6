namespace OOParv
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Dog dog = new Dog("Pluto", 10, "black and white", false);
            Cat cat = new Cat("Kitty", 5, "White", false, "HouseCat");
            Fish fish = new Fish("Nemo", 5, "Orange", true, true);
            Lion lion = new Lion("Simba", 25, "Orange", true);
            Cheetah cheetah = new Cheetah("MrBolt", 30, "Green", "gasells");


            dog.DailyActivitesAnimal();
            cat.DailyActivitesAnimal();
            lion.DailyActivitesAnimal();
            cheetah.DailyActivitesAnimal();
            fish.DailyActivitesAnimal();





        }
    }
}

