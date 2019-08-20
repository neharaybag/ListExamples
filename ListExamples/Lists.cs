using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExamples
{
    class Lists
    {
        public static object Gear { get; private set; }

        static void Main(string[] args)
        {
            // Simple String list

            var foodItems = new List<String>();

            foodItems.Add("Milk");
            foodItems.Add("Bread");
            foodItems.Add("Pizza");
            foodItems.Add("Tea");
            foodItems.Add("Coffee");
            foodItems.Add("Rice");

            PrintList(foodItems);

            // Remove one item
            foodItems.Remove("Pizza");

            Console.WriteLine("Pizza is removed");

            PrintList(foodItems);

            foodItems.Sort();

            Console.WriteLine("After sorting");

            PrintList(foodItems);


            // List of objects

            var listCycles = new List<Cycle>();

            listCycles.Add(new Cycle("Scott", "Speedster 20", Gears.Tiagra, 69000));
            listCycles.Add(new Cycle("Scott", "Speedster 10", Gears.OneOFive, 110000));
            listCycles.Add(new Cycle("Btwin", "Tiriban 520RC", Gears.OneOFive, 75000));
            listCycles.Add(new Cycle("Scott", "Addict 10", Gears.Ultgra, 150000));

            // Print cycle models with price less that 100000
            Console.WriteLine("Cycle models less than 100000");

            foreach (var cycle in listCycles)
            {
                if (cycle.Price < 100000)
                {
                    Console.WriteLine(cycle.Model);
                }
            }

            // Print all cycles with branch Scott

            Console.WriteLine("Cycle models of Scott brand");

            foreach (var cycle in listCycles)
            {
                if(cycle.Brand.Equals("Scott"))
                {
                    Console.WriteLine(cycle.Model);
                }
            }           

            Console.ReadLine();

            

        }


        public static void PrintList(List<string> list)
        {
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
