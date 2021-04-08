using System;
namespace Lab04
{
    public class Cat : IBehavior
    {
        public string FurColor {get; set;}
        public int Age {get; set;}

        public void Eat(string food)
        {
            Console.WriteLine("La serpiente engulle su comida")
        }
    }
}