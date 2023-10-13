namespace OOParv
{
    class Animal
    {

        public string Name { get; set; } = "unknown";
        public int Age { get; set; } = -1;
        public string Color { get; set; } = "unknown";
        public string TypeOfAnimal { get; set; } = "animal";
        public bool WildAnimal { get; set; } = false;


        public Animal(string name, int age, string color, string typeOfAnimal, bool wildAnimal)
        {
            Name = name;
            Age = age;
            Color = color;
            TypeOfAnimal = typeOfAnimal;
            WildAnimal = wildAnimal;
        }


        public virtual void MakeSound()
        {
            Console.WriteLine("Animal making sounds..");

        }

        public void EatingTime()
        {
            Console.WriteLine("FoodTime Yeah!");
        }

        public void DailyRunning()
        {
            Console.WriteLine("Run, run, Run, run..!!");
        }



    }
}


