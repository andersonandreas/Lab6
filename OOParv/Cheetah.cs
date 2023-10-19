namespace OOParv
{
    internal class Cheetah : Cat
    {
        public string FavoriteFood { get; set; } = "any meat";
        public Cheetah(string name, byte age, string color, string favoriteFood)
            : base(name, age, color, true, "Cheetah")
        {
            FavoriteFood = favoriteFood;

        }


        public override void DailyActivitesAnimal()
        {
            base.DailyActivitesAnimal();
            this.Running100M();

        }

        public void Running100M()
        {
            Console.WriteLine($"Im a {this.Species} and im the fastest animal in the world, try to catch me!..");
        }
        protected override void MakeSound()
        {
            Console.WriteLine($"{this.Species} Growls, purrs!.");
        }
        protected override void EatingTime()
        {
            Console.WriteLine($"Likes to eat {this.FavoriteFood}");

        }
        protected override void DailyRunning()
        {
            Console.WriteLine($"{this.Name} like to chase just about anything that moves");

        }
    }
}
