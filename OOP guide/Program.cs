using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_guide
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of dog using..
            // .. default constructor
            var dogDefault = new Dog();
            // .. parameterised constructor
            var dogSpecific = new Dog("Ricky", DateTime.Now, 40, 60, 20, 
                Color.Blue, Color.Brown );
            // Calling instance method
            dogDefault.Come();
            Console.WriteLine(dogSpecific.Age);
            MagicConverter.Convert("Hello world");
        }
    }
}
