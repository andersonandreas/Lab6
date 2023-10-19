namespace OOParv
{
    class Dog : Animal
    {

        public bool HaveABone { get; set; } = false;

        public Dog(string name, byte age, string color, bool haveABone)
            : base(name, age, color, "Dog", false)
        {
            HaveABone = haveABone;
        }

        public override void DailyActivitesAnimal()
        {

            base.DailyActivitesAnimal();
            this.SearchingForBone();

        }

        protected void SearchingForBone()
        {
            if (HaveABone == true)
            {
                Console.WriteLine($"{this.Name} searching for the bone that was lost two seconds ago, hmm..");
            }
            else
            {
                Console.WriteLine("Naaah playing with a bone.. I don't get it! Why dont relax and maybe taking a napp instead?! :)");
            }
        }

        protected override void MakeSound()
        {
            Console.WriteLine("The dogs woof woof!");
        }

        protected override void EatingTime()
        {
            Console.WriteLine($"{this.Name} like to eat typical {this.TypeOfAnimal} food and bones.");
        }

        protected override void DailyRunning()
        {
            Console.WriteLine($"I'm just running when i chasing the cat hahaha..");
        }
    }
}




