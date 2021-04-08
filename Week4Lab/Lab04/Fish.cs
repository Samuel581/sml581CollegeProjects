using System;
namespace Lab04
{
    public class Fish : IBehavior
    {
        public string Colors {get; set;}

        public void Eat(string food)
        {
            Console.WriteLine("El pescao come");
        }

        public void Move()
        {
            throw new System.NotImplementedException();
        }
    }
}