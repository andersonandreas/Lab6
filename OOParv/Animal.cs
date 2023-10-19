namespace OOParv
{
    public abstract class Animal
    {

        public string Name { get; set; } = "Unknown";
        public byte Age { get; set; } = 0;
        public string Color { get; set; } = "Unknown";
        public string TypeOfAnimal { get; set; } = "animal";
        public bool WildAnimal { get; set; } = false;


        public Animal(string name, byte age, string color, string typeOfAnimal, bool wildAnimal)
        {
            Name = name;
            Age = age;
            Color = color;
            TypeOfAnimal = typeOfAnimal;
            WildAnimal = wildAnimal;
        }



        public virtual void DailyActivitesAnimal()
        {
            Console.WriteLine("\nActivities:");
            this.MakeSound();
            this.EatingTime();
            this.DailyRunning();


        }

        protected abstract void MakeSound();
        protected abstract void EatingTime();
        protected abstract void DailyRunning();



    }
}


