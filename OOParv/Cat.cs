namespace OOParv
{

    class Cat : Animal
    {
        public string Species { get; set; } = "Unknown";

        public Cat(string name, byte age, string color, bool wildAnimal, string species)
            : base(name, age, color, "Cat", wildAnimal)

        {
            Species = species;
        }


        public override void DailyActivitesAnimal()
        {
            base.DailyActivitesAnimal();
            this.MythAboutCats();

        }


        protected void MythAboutCats()
        {
            Console.WriteLine("Cats has 9 lives.");
        }
        protected override void MakeSound()
        {
            Console.WriteLine("The cat Meow Meow!.");
        }
        protected override void EatingTime()
        {
            Console.WriteLine("Eating fishes and rat");

        }
        protected override void DailyRunning()
        {
            Console.WriteLine($"{this.Name} like to chase just about anything that moves");

        }
    }
}



