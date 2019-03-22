using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue();

            /* Task 1 */
            string yes = "y";
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter a name");
                q1.Enqueue(Console.ReadLine());
                Console.Write("Would you like to add another name (y/n)");
                yes = Console.ReadLine();
            } while (yes == "y");


            /* Task 2 */
            string search = "y";
            do
            {
                Console.Clear();
                Console.Write("Enter a name to search a name?");
                string input = Console.ReadLine();

                if (q1.Contains(input) == true)
                    Console.WriteLine("Item found");
                else
                    Console.WriteLine("Item not found");


                Console.Write("Would you like to search for another name (y/n)");
                search = Console.ReadLine();
                Console.WriteLine();
            } while (search == "y");

            Display(q1);
        }
        static void Display(Queue q1)
        {
            Console.WriteLine("..... Queues .....");
            while (q1.Count > 0)
            {
                Console.WriteLine("Number of Elements: " + q1.Count);
                Console.WriteLine($"Dequeued - {q1.Dequeue()}");
            }



        }
    }
}





