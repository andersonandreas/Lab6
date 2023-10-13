namespace OOParv
{
    internal class Fish : Animal
    {

        public bool ColdBlooded { get; set; }

        public Fish(string name, int age, string color, bool wildAnimal, bool coldBlooded)
            : base(name, age, color, "Fish", wildAnimal)
        {
            ColdBlooded = coldBlooded;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Plask Plask..");
        }

        public void swimming()
        {
            Console.WriteLine("\n¸.·´¯`·.´¯`·.¸¸.·´¯`·.¸><(((º>\n");
        }


    }
}

