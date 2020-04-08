using System;
using FarmSystem;
using FarmSystem.Models;

namespace FarmSystemConsole
{
    class Program
    {
        private const string Separator = "________________________________";

        static void Main(string[] args)
        {
            Console.WriteLine("Emydex Farm test to evaluate Allan Nielsen on his understanding of OOP concepts.");
            Console.WriteLine();
            Console.WriteLine("Assumptions made:");
            Console.WriteLine(" - animals entering the farm will always leave in the same order - Queue");
            Console.WriteLine(" - removed code that was never used - Cow.Walk");
            Console.WriteLine(" - though Id is never used, maintained for OO exmple reasons (see tests)");
            Console.WriteLine(" - animal names can just come from the animal type, alternately could have returned other name from implementing class (as shown with NoOfLegs)");
            Console.WriteLine();
            Console.WriteLine("Additional effort:");
            Console.WriteLine("  As this was a test, I took the initiative and upgraded the project to use");
            Console.WriteLine(".NET Core and Standard as this will soon be .NET 5 and the Framework the old");
            Console.WriteLine("project used will no longer be supported.");
            Console.WriteLine("  Also split the busines logic from the client and ensured more script component use.");
            Console.WriteLine();
            Console.WriteLine("Out of scope:");
            Console.WriteLine("  - Use factory pattern for creation of IAnimal instances by type");
            Console.WriteLine("  - Alter animals to have behavioural collection instead of hard coded methods allowing future extensibility");
            Console.WriteLine();
            Console.WriteLine("Please note that a test project was also included to ensure excercises would");
            Console.WriteLine("pass when executed.  This project and tests was created before attempting any");
            Console.WriteLine("modifications to ensure accuracy and to determine remaining work. TDD in practice.");
            Console.WriteLine("I only partially commented my code (see animal) though normally I would do all.");
            Console.WriteLine();

            Excercise1();
            Excercise2();
            Excercise3();
            Excercise4();

            Console.WriteLine("All excercises complete.");
            Console.ReadKey();
        }

        private static void DoExcercise(string title, Action<EmydexFarmSystem> action)
        {
            Console.WriteLine("{0} Actual output {0}", Separator);
            Console.WriteLine(title);
            Console.ReadKey();

            var farm = EmydexFarmSystem.CreateFarm();
            farm.FarmActivity += (o, e) => Console.WriteLine(e.Message);

            var cow = Market.Purchase(typeof(Cow));

            farm.Enter(cow, Market.Purchase(typeof(Hen)), Market.Purchase(typeof(Horse)), Market.Purchase(typeof(Sheep)));

            action?.Invoke(farm);

            Console.WriteLine(new string('_', 79));
            Console.WriteLine("Exercise complete");
            Console.WriteLine();
            Console.ReadKey();
        }

        /************************************************************************************************************
        Exercise 1 : Apply OOP concepts (abstraction and encapsulation) to the classes 
        modify the code to get the output below
        Cow has entered the farm
        Hen has entered the farm
        Horse has entered the farm
        Sheep has entered the farm
        ***************************************************************************************************************/
        private static void Excercise1()
        {
            DoExcercise("Exercise 1 : Press any key when it is time to open the Farm to animals", null);
        }

        /***************************************************************************************************************
         Test Excercise 2
         If you have completed the first test excercise, you can continue with the second one
         Modify the program and EmydexFarmSystem.MakeNoise() method to get the below output
         Expected Test 2 Program Output

         Exercise 2 : Press any key to scare the animals in the farm
            Cow has entered the farm
            Hen has entered the farm
            Horse has entered the farm
            Sheep has entered the farm
            Cow says Moo!
            Hen says CLUCKAAAAAWWWWK!
            Horse says Neigh!
            Sheep says baa!
         *****************************************************************************************************************/
        private static void Excercise2()
        {
            DoExcercise("Exercise 2 : Press any key to scare the animals in the farm", f => f.MakeNoise());
        }

        /*****************************************************************************************************************
        Test Excercise 3
        If you have completed the previous test excercise, you can continue with this one 
        The project includes an interface IMilkableAnimal. Make use of this interface to implement on the relevant classes
        so that calling the EmydexFarmSystem.MilkAnimals() method to get the below output

        Expected Test 3 Program Output

        Exercise 3 : Press any key when it is time to milk animals
        Cow has entered the farm
        Hen has entered the farm
        Horse has entered the farm
        Sheep has entered the farm
        Cow was milked!
        ************************************************************************************************************/
        private static void Excercise3()
        {
            DoExcercise("Exercise 3 : Press any key when it is time to milk animals", f => f.MilkAnimals());
        }

        /****************************************************************************************************
        Test Excercise 4
        Modify the EmydexFarmSystem.ReleaseAllAnimals() so that all animals are released (simply clear the collection )
        Expose an event on the FarmSystem FarmEmpty which is invoked once all the animals are released
        Subscribe to that event in the main to get the expected output

        Expected Test 4 Program Output

        Exercise 4: Press any key to free all animals
        Cow has entered the farm
        Hen has entered the farm
        Horse has entered the farm
        Sheep has entered the farm
        Cow has left the farm
        Hen has left the farm
        Horse has left the farm
        Sheep has left the farm
        Emydex Farm is now empty
        ********************************************************************************************************************/
        private static void Excercise4()
        {
            DoExcercise("Exercise 4: Press any key to free all animals", f => f.ReleaseAllAnimals());
        }
    }
}
