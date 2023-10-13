namespace OOParv
{
    internal class Cheetah : Cat
    {
        public bool FastestAnimal { get; set; } = true;
        public Cheetah(string name, int age, string color)
            : base(name, age, color, true, "Cheetah")
        {


        }


        public override void MakeSound()
        {
            Console.WriteLine("The Cheetah growls and purrs!.");
        }

        public void Sprinting()
        {
            Console.WriteLine($"Im a {this.Species} and im the fastest animal in the world, try to catch me!..");
        }


    }
}
