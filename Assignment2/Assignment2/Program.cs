using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    struct Customer
    {
        public  string name; 
        public int customer_id; 
        public  long acc_no; 
        public int opening_bal;

        public Customer(string n, int cus_id, long a_no, int o_bal)
        {
             
             name= n;
             customer_id = cus_id;
             acc_no = a_no;
             opening_bal = o_bal;
             
        }
        
       
    }  

    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customer = new Customer[10];
            customer[0] = new Customer("Swati", 0, 12345, 1000);
            customer[1] = new Customer("Saqeeb", 1, 23456, 2000);
            customer[2] = new Customer("Shashank", 2, 34567, 500);
            customer[3] = new Customer("Ankush", 3, 45678, 2000);
            customer[4] = new Customer("Haripriya", 4, 56789, 4000);
            customer[5] = new Customer("Rahul", 5, 67890, 5000);
            customer[6] = new Customer("Jishnu", 6, 78901, 1000);
            customer[7] = new Customer("Ankitha", 7, 90123, 500);
            customer[8] = new Customer("Akanksha", 8, 01234, 2500);
            customer[9] = new Customer("Manogna", 9, 09876, 1000);

            
                Console.WriteLine("Enter your customer id");
                int c = int.Parse(Console.ReadLine());

                for (int i = 0; i < 9; i++)
                {
                    if (c == i)
                    {
                        Console.WriteLine("Name: {0} \n" +
                            "Account number: {1} \n", customer[c].name, customer[c].acc_no);
                        break;
                    }

                }
            menu();
             void menu()
            {
                back();
                void back()
                {

                    Console.WriteLine("Select one of the options: \n" +
                        "Press (1) for Withdrawal\n" +
                        "Press (2) for Deposit\n" +
                        "Press (3) for Viewing Balance\n" +
                        "Press (4) for Exit"
                        );
                    int a = int.Parse(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter the amount you want to withdraw.");
                                int x = int.Parse(Console.ReadLine());
                                withdraw(x);
                                Console.WriteLine("Do you want to continue? y/n");
                                {
                                    string s = Console.ReadLine();
                                    if (s == "y")
                                        back();
                                }
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("Enter the amount you want to deposit.");
                                int x = int.Parse(Console.ReadLine());
                                deposit(x);

                                Console.WriteLine("Do you want to continue? y/n");
                                {
                                    string s = Console.ReadLine();
                                    if (s == "y")
                                        back();
                                }

                            }
                            break;
                        case 3:
                            {

                                Console.WriteLine("Your balance is " + customer[c].opening_bal);
                                Console.WriteLine("Do you want to continue? y/n");
                                {
                                    string s = Console.ReadLine();
                                    if (s == "y")
                                        back();
                                }
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Thank you!");
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Invalid Entry.Do you want to continue? y/n");
                                string s = Console.ReadLine();
                                if (s == "y")
                                    back();
                            }
                            break;
                    }

                }
            }
            

            void withdraw(int x)
            {
                int t=customer[c].opening_bal;
                int y = t - x;

                if (y < 500)
                {
                    Console.WriteLine("Cannot Withdraw this amount.");
                    int d = 500 - t;
                    Console.WriteLine("You can withdraw {0} or less ", d);
                }
                else
                {
                    Console.WriteLine("Account balance after withdrawing is " + y);
}

            }
             void deposit(int x)
            {
                int t = customer[c].opening_bal;
                int y = t + x;
                Console.WriteLine("Account balance after depositing is " + y);

            }
   
        }
        }
    }

