namespace OOParv
{

    class Lion : Cat
    {

        public bool KingOfDjungle { get; set; } = true;

        public Lion(string name, int age, string color, bool kingOfDjungle)
            : base(name, age, color, true, "Lion")
        {
            KingOfDjungle = kingOfDjungle;
        }

        public override void MakeSound()
        {
            Console.WriteLine("The lion roar and is very loud!.");
        }

        public void DjungleKing()
        {
            Console.WriteLine($"People saying that i'm the king of the djungle, but i need to verify this: ({(bool)this.KingOfDjungle}).");
        }


    }
}
