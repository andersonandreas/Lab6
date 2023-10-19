namespace OOParv
{
    internal class Fish : Animal
    {

        public bool ColdBlooded { get; set; }

        public Fish(string name, byte age, string color, bool wildAnimal, bool coldBlooded)
            : base(name, age, color, "Fish", wildAnimal)
        {
            ColdBlooded = coldBlooded;
        }


        public override void DailyActivitesAnimal()
        {
            base.DailyActivitesAnimal();
            this.swimming();


        }

        protected void swimming()
        {
            Console.WriteLine("\n¸.·´¯`·.´¯`·.¸¸.·´¯`·.¸><(((º>\n");
        }

        protected override void MakeSound()
        {
            Console.WriteLine("Plask Plask..");
        }

        protected override void EatingTime()
        {
            Console.WriteLine("Eating small fishes and seagrass..");
        }

        protected override void DailyRunning()
        {
            Console.WriteLine("i don't run.. I swim!");
        }
    }
}

