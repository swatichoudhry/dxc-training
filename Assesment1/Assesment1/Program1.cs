using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment1
{
    class Products
    {

    }
    class Program1
    {
        static void Main(string[] args)
        {
            int total = 0;
            int y=0,m=0,n=0,k=0,z=0;
            back();
            void back() {
                Console.WriteLine("Select one product you want to buy: \n" +
                    "type 'a' for apple, \n" +
                    "'b' for butter \n" +
                    "'c' for cheese, \n" +
                    "'d' for dosa and " +
                    "\n'e' for eggs ");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "a":
                        { Console.WriteLine("What quantity of apple you want: select 1-10.");
                            y = int.Parse(Console.ReadLine());
                            Console.WriteLine(" Do you want to continue?y/n");
                            string q = Console.ReadLine();
                            if (q == "y")
                                back();
                        }
                        break;
                    case "b":
                        {
                            Console.WriteLine("What quantity of butter you want: select 1-10.");
                            z = int.Parse(Console.ReadLine());
                            Console.WriteLine(" Do you want to continue?y/n");
                            string q = Console.ReadLine();
                            if (q == "y")
                                back();
                        }
                        break;
                    case "c":
                        {
                            Console.WriteLine("What quantity of cheese you want: select 1-10.");
                            m = int.Parse(Console.ReadLine());
                            Console.WriteLine(" Do you want to continue?y/n");
                            string q = Console.ReadLine();
                            if (q == "y")
                                back();
                        }
                        break;
                    case "d":
                        {
                            Console.WriteLine("What quantity of dosa you want: select 1-10.");
                            n = int.Parse(Console.ReadLine());
                            Console.WriteLine(" Do you want to continue?y/n");
                            string q = Console.ReadLine();
                            if (q == "y")
                                back();
                        }
                        break;
                    case "e":
                        {
                            Console.WriteLine("What quantity of eggs you want: select 1-10.");
                            k = int.Parse(Console.ReadLine());
                            Console.WriteLine(" Do you want to continue?y/n");
                            string q = Console.ReadLine();
                            if (q == "y")
                                back();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid Entry. Do you want to continue?y/n");
                            string q = Console.ReadLine();
                            if (q == "y")
                                back();
                        }
                        break;
                }

                

            }
            Console.WriteLine(
                    "Apples: {0}x30 \n" +
                    "Butter: {1}x20 \n" +
                    "Cheese: {2}x40 \n" +
                    "Dosa: {3}x35\n" +
                    "Eggs: {4}x5", y, z, m, n, k);

            total = y * 30 + z * 20 + m * 40 + n * 35 + k * 5;
            Console.WriteLine("The total amount of your bill is " + total);
            Console.WriteLine();

        }
    }
}
