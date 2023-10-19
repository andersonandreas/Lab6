namespace OOParv
{

    class Lion : Cat
    {

        public bool KingOfDjungle { get; set; } = true;

        public Lion(string name, byte age, string color, bool kingOfJungle)
            : base(name, age, color, true, "Lion")
        {
            KingOfDjungle = kingOfJungle;
        }

        public override void DailyActivitesAnimal()
        {

            base.DailyActivitesAnimal();
            this.DjungleKing();
        }


        protected void DjungleKing()
        {
            Console.WriteLine($"People saying that i'm the king of the jungle, but i need to verify this: ({(bool)this.KingOfDjungle}).");
        }
        protected override void MakeSound()
        {
            Console.WriteLine("The Lion RoarRoar!.");
        }
        protected override void EatingTime()
        {
            Console.WriteLine("Like to eat meat in Safari djungle");

        }
        protected override void DailyRunning()
        {
            Console.WriteLine($"{this.Name} doing some daily running.");

        }



    }
}
