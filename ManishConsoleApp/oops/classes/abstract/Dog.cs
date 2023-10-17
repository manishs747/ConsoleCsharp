using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.oops.classes
{
    public abstract class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("I am an animal.");
        }

        public abstract void Name();
    }

    public class Dog : Animal
    {

        public static void Main()
        {
            Animal animal = new Dog();
            animal.Speak();
            animal.Name();

            Dog dog = new Dog();
            dog.Speak();
            dog.Name();

        }
        public override void Speak()
        {
            Console.WriteLine("Woof!");
        }

        public override void Name() { Console.WriteLine("I am Dog"); }

    }





}
