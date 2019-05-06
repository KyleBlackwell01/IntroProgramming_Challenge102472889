using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            int count2 = 0;
            int totalR = 0;
            var random = new Random();

            //Defines Options;
            List<int> choice = new List<int> { 1, 2, 3, 4, 5, 6 };

            //Holds the results
            List<int> result = new List<int>();



            Console.WriteLine("Dice Roller");
            Console.WriteLine("Roll Dice? Y/N");

            //Player input
            string test = Console.ReadLine();


         
            while (count < 1)
            {

                count++;

                int index = random.Next(choice.Count);

                if (test == "Y" | test == "Yes")
                {
                    Console.WriteLine("Dice Rolled: " + choice[index]);

                    result.Add(choice[index]);
                    

                }
                else if (test == "N" | test == "No")
                {
                    Console.WriteLine("Goodbye.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid Input, ending program.");
                    break;
                }

                while (count2 < 1)
                {

                    Console.WriteLine("Would you like to stop?");

                    string test2 = Console.ReadLine();

                    if (test2 == "Y" | test2 == "Yes")
                    {

                        Console.WriteLine("How many rolls do you want to view?");
                        totalR = int.Parse(Console.ReadLine());


                        List<int> result2 = result.GetRange(0, totalR);

                        double average = result2.Count > 0 ? result2.Average() : 0.0;

                        Console.WriteLine("Average of Rolls: " + average);

                        Console.WriteLine("Total: " + result2.Sum());


                        result2.ForEach(x => { Console.WriteLine("Rolled: " + x); });


                        count2++;

                    }
                    else
                    {
                        index = random.Next(choice.Count);
                        Console.WriteLine("Continuing dice roll.");
                        Console.WriteLine("Dice Rolled: " + choice[index]);

                        result.Add(choice[index]);
                    }

                }
                
            }

            Console.ReadKey();

        }
    }
}
