using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment1
{ class shape
    {
        double radius;
        int length, breadth, x, y, z;
       public shape(double r)
        {
            radius = r;
            Console.WriteLine("The selected shape is a circle and the given parameter is, radius= " + r+"cm");
            area1(r);
             void area1(double a) {
                double b;
                b = 3.14 * radius * radius;
                Console.WriteLine("Area of the circle is: " + b+" cm");
            }
        }
        
        public  shape(int l,int b)
        {
            length = l;
            breadth = b;
            Console.WriteLine("The selected shape is Rectangle and the parameters" +
                " are length={0} cm and breadth={1} cm.",length,breadth);
            area2(length, breadth);
            void area2(int i,int j)
            {
                int a;
                a = i * j;
                Console.WriteLine("The area is: " + a+" cm");
            }

        }
        
        public shape(int l,int b,int h)
        {
            x = l;
            y = b;
            z = h;
            area3(x, y, z);
            Console.WriteLine("Selected shape is cuboid and the given parameters are," +
                " length= {0} cm,breadth= {1} cm and height= {2} cm", x, y, z);
            void area3(int i, int j, int k)
                {
                int a;
                a = i * j * k;
                Console.WriteLine("Area is " + a + " cm");

            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double rad;
            int length, breadth, a, b, c;
            back();
            void back()
            {
                Console.WriteLine("Select a shape: 1 for circle," +
                    "2 for rectangle, 3 for cuboid");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the radius in cm: ");
                            rad = int.Parse(Console.ReadLine());
                            shape shape = new shape(rad);
                            Console.WriteLine("Do you want to continue?y/n");
                            string q = Console.ReadLine();
                            if (q == "y") {
                                back();
                            }
                            

                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter the length and breadth in cm: ");
                            length = int.Parse(Console.ReadLine());
                            breadth = int.Parse(Console.ReadLine());
                            shape shape = new shape(length, breadth);
                            Console.WriteLine("Do you want to continue?y/n");
                            string q = Console.ReadLine();
                            if (q == "y")
                            {
                                back();
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter the length and breadth and height in cm: ");
                            a = int.Parse(Console.ReadLine());
                            b = int.Parse(Console.ReadLine());
                            c = int.Parse(Console.ReadLine());
                            shape shape = new shape(a, b, c);
                            Console.WriteLine("Do you want to continue?y/n");
                            string q = Console.ReadLine();
                            if (q == "y")
                            {
                                back();
                            }
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Invalid Entry.");
                            Console.WriteLine("Do you want to continue?y/n");
                            string q = Console.ReadLine();
                            if (q == "y")
                            {
                                back();
                            }
                        }

                            break;


                }
            }
            Console.ReadLine();

        }
    }
}
