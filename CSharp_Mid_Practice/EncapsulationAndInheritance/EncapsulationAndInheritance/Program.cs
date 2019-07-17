using EncapsulationAndInheritance.AdditionalTask;
using EncapsulationAndInheritance.FromYoutube;
using System;

namespace EncapsulationAndInheritance.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var namas = new Namas(7);
            var duruSkaicius = namas.duruSkaicius;

            Console.WriteLine(duruSkaicius);

            Console.ReadLine();



            Car masina = new Car(120, 4, false);
            masina.Move();










            Animal animal = new Animal(4, "male", 7);
            Bird duck = new Bird(2, "female", 2, "white", true, "LTU");

            Console.WriteLine(animal.LegsCount);
            Console.WriteLine(animal.GetGender());
            Console.WriteLine(animal.GetAge());

            Console.WriteLine(duck.GetAge());
            Console.WriteLine(duck.GetCanFly());
            Console.WriteLine(duck.GetCountry());
            Console.WriteLine(duck.GetGender());
            Console.WriteLine(duck.LegsCount);
            Console.WriteLine(duck.Color);


            animal.PrintAnimal();
            duck.PrintBird();

            Console.ReadLine();

        }
    }
}
