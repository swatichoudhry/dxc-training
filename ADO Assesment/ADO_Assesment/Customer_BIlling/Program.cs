using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Customer_BIlling
{
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Product_ID { get; set; }
        public int Quantity { get; set; }
        public int Supplier_ID { get; set; }
    }
    class Program
    {
        static SqlConnection con;
        static string ConnectionString = "data source= IN5CG9292J9P; database= ADO_Assesment;integrated security = true";
        static SqlCommand cmd;
        static void Main(string[] args)
        {
            CustomerDetails();          
           



        }
        static public void ProductDetails()
        {
            con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Products";          
            cmd.Connection = con;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t{rdr[1]}");
            }
            con.Close();
        }
        static public void SupplierDetails1()
        {
            con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Suppliers where Product_ID=1";
            cmd.Connection = con;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t\t{rdr[1]}\t\t{rdr[2]}\t\t{rdr[3]}");
            }
            con.Close();
        }
        static public void SupplierDetails2()
        {
            con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Suppliers where Product_ID=2";
            cmd.Connection = con;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t\t{rdr[1]}\t\t{rdr[2]}\t\t{rdr[3]}");
            }
            con.Close();
        }
        static public void SupplierDetails3()
        {
            con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Suppliers where Product_ID=3";
            cmd.Connection = con;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t\t{rdr[1]}\t\t{rdr[2]}\t\t{rdr[3]}");
            }
            con.Close();
        }
        static public void SupplierDetails4()
        {
            con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Suppliers where Product_ID=4";
            cmd.Connection = con;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t\t{rdr[1]}\t\t{rdr[2]}\t\t{rdr[3]}");
            }
            con.Close();
        }
        

    public static void CustomerDetails()
    {           
            Customer customer = new Customer();
            Console.WriteLine("Enter your Name");
            //customer.ID = int.Parse(Console.ReadLine());
            customer.Name = Console.ReadLine();
            ProductDetails();
        start: Console.WriteLine("Select one product.");
            int x = int.Parse(Console.ReadLine());
            customer.Product_ID = x;
            switch (x)
            {
                case 1:
                    SupplierDetails1();
                    break;
                case 2:
                    SupplierDetails2();
                    break;
                case 3:
                    SupplierDetails3();
                    break;
                case 4:
                    SupplierDetails4();
                    break;
                default:
                    {
                        Console.WriteLine("Invalid Entry.Please try again.");
                        goto start;
                    }
            }
            
            Console.WriteLine("Select One Supplier");
            customer.Supplier_ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Quantity.");
            customer.Quantity = int.Parse(Console.ReadLine());
            SqlConnection con = new SqlConnection();
        con.ConnectionString = "data source= IN5CG9292J9P; database= ADO_Assesment;integrated security = true";
        SqlCommand cmd = new SqlCommand();     
        //cmd.Parameters.AddWithValue("@ID", customer.ID);
        cmd.Parameters.AddWithValue("@Name", customer.Name);
        cmd.Parameters.AddWithValue("@Product_ID", customer.Product_ID);
        cmd.Parameters.AddWithValue("@Quantity", customer.Quantity);
        cmd.Parameters.AddWithValue("@Supplier_ID", customer.Supplier_ID);
        cmd.CommandText = "insert into Customers values(@Name,@Product_ID,@Quantity,@Supplier_ID)";
        cmd.Connection = con;
        con.Open();
        int rowcount = cmd.ExecuteNonQuery();
        if (rowcount > 0)
        {
            Console.WriteLine("Record inserted sucessfully");
        }
        con.Close();
    }
}
}
