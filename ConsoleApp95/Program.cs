using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp95
{

    class conncetionstring
    {
        string connectiondb;
        SqlConnection conn;
        public conncetionstring(string connectiondb)
        {
            this.connectiondb = connectiondb;
            conn = new SqlConnection(connectiondb);
        }
        public void openconncetion()
        {
            try
            {
                conn.Open();
                Console.WriteLine("connection open suceessfuly");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void closeconncetion()
        {
            if(conn.State==System.Data.ConnectionState.Open)
            {
                conn.Close();
                Console.WriteLine("conncetion closed succeessfuly");
            }
        }

    }

    class student
    {
        int id;
        string name;
        int age;
        public student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            //if (age >= 18 && age <= 60)
            //{
            this.age = age;

             //}
            
            
        }
        public void displaystudent()
        {
            Console.WriteLine("student is is:"+this.id);
            Console.WriteLine("student name is:" + this.name);
            if (this.age >=18 && this.age <= 60)
            {

                Console.WriteLine("student age is:" + age);
            }
            else
            {
                Console.WriteLine("invalid age");
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string dbconn = "Server=.;Initial Catalog=Userdatabase;Integrated Security=True;";
            conncetionstring db=new conncetionstring(dbconn);
            db.openconncetion();
            db.closeconncetion();
            Console.WriteLine("===================Student example==============");
            Console.WriteLine("enter student id");
            int id=int.Parse(Console.ReadLine());
          
            Console.WriteLine("enter student name :");
            string name=Console.ReadLine();
            Console.WriteLine("enter student age");
            int age = int.Parse(Console.ReadLine());
            //int age2;
            //while (true)
            //{
            //    Console.WriteLine("enter student age");
            //   age2 = int.Parse(Console.ReadLine());
            //    if (age2>=18&&age2<=60)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("enter age between 18 to 60");
            //}
            student s = new student(id, name, age);
            s.displaystudent();
            


        }
    }
 }

