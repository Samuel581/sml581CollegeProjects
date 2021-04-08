using System;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            var Fish = new Fish(){Colors="Blanquito"};
            Fish.Eat("Wishkas");
            Fish.Move();

            var Cat = new Cat();
            Cat.Eat("Raton");
        }
    }
}
