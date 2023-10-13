namespace OOParv
{

    class Cat : Animal
    {
        public string Species { get; set; }

        public Cat(string name, int age, string color, bool wildAnimal, string species)
            : base(name, age, color, "Cat", wildAnimal)

        {
            Species = species;
        }


        public override void MakeSound()
        {
            Console.WriteLine("The cat Meow Meow!.");
        }

        public void MythAboutCats()
        {
            Console.WriteLine("Cats has 9 lives.");
        }

    }
}



