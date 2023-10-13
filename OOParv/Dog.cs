namespace OOParv
{
    class Dog : Animal
    {

        public bool HaveABone { get; set; } = false;

        public Dog(string name, int age, string color, bool haveABone)
            : base(name, age, color, "Dog", false)
        {
            HaveABone = haveABone;
        }


        public virtual void makeSound()
        {
            Console.WriteLine("The dogs woof woof!");
        }

        public void SearchingForBone()
        {
            if (HaveABone == true)
            {
                Console.WriteLine($"{this.Name} searching for the bone that was lost two seconds ago, hmm..");
            }
            else
            {
                Console.WriteLine("I don't get it! Why dont relax and maybe taking a napp instead?! :)");
            }
        }

    }
}




