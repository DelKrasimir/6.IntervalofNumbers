using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7BakingIngredients
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;

            for (int i = 1; i <= 21; i++)
            {

                var ingredient = Console.ReadLine();

                if (ingredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                    break;
                }

                counter++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
            }

        }
    }
}