using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;


namespace ConsoleApp95
{

  public class protectd:testingprotected
    {
        public void displaypro()
        {
            Console.WriteLine("protected testing" + c);
        }

    }
    
    //constractor over loading
    //class contractureoverload
    //{

    //    int sid;
    //    string name;
    //    int age;
    //    public contractureoverload()
    //    {
    //        sid = 123;
    //        name = "sandy";
    //        //age = 20;

    //    }
    //    public contractureoverload(int Sid)
    //    {
    //        sid = Sid;
    //        name = "not provide";
           
        
    //    }
    //    public contractureoverload(string Name)
    //    {
    //        name = Name;
        

    //    }
    //    public contractureoverload(int Sid,string Name)
    //    {
    //        sid=Sid;
    //        name = Name;

    //    }
      
    //    public void display()
    //    {
    //        Console.WriteLine("sid is:" + sid);
    //        Console.WriteLine("sname:"+name);
    //        Console.WriteLine("age is"+age);
            
    //    }

    //}






    //class st3:st2
    //{
    //    public void st3disply()
    //    {
    //        Console.WriteLine("st3"+id);
    //    }
    //}
    //class st5 : st4
    //{
    //    public void st5disply()
    //    {
    //        Console.WriteLine("st5" + pid);
    //    }
    //}





    // public class conncetionstring
    //{
       
       
    //    string connectiondb;
    //    SqlConnection conn;
    //    public conncetionstring(string connectiondb)
    //    {
    //        this.connectiondb = connectiondb;
    //        conn = new SqlConnection(connectiondb);
    //    }
    //    public void openconncetion()
    //    {
    //        try
    //        {
    //            conn.Open();
    //            Console.WriteLine("connection open suceessfuly");
    //        }
    //        catch(Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //    }
    //    public void closeconncetion()
    //    {
    //        if(conn.State==System.Data.ConnectionState.Open)
    //        {
    //            conn.Close();
    //            Console.WriteLine("conncetion closed succeessfuly");
    //        }
    //    }

    //}

   //internal class myclass
   // {
   //     protected internal string name;
   //     public void print()
   //     {
   //         name = "sandeep";
   //         Console.WriteLine(name);
   //     }

   // }


    //class student
    //{
    //    int id;
    //    string name;
    //    int age;
    //    public student(int id, string name, int age)
    //    {
    //        this.id = id;
    //        this.name = name;
    //        //if (age >= 18 && age <= 60)
    //        //{
    //        this.age = age;

    //         //}
            
            
    //    }
    //    public void displaystudent()
    //    {
    //        Console.WriteLine("student is is:"+this.id);
    //        Console.WriteLine("student name is:" + this.name);
    //        if (this.age >=18 && this.age <= 60)
    //        {

    //            Console.WriteLine("student age is:" + age);
    //        }
    //        else
    //        {
    //            Console.WriteLine("invalid age");
    //        }

    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            //contractureoverload constr=new contractureoverload();
            //constr.display();
            //Console.WriteLine("===========================");
            //contractureoverload obj=new contractureoverload(122);
            //obj.display();
            //Console.WriteLine("===========================");
            //contractureoverload obj2 = new contractureoverload(123,"rama");
            //obj2.display();
            //Console.WriteLine("===========================");
            //contractureoverload obj3 = new contractureoverload( "rama2");
            //obj3.display();




            //protected internal:

            //diplayemp1 obj = new diplayemp1();
            //  obj.displayemp();

            //  st ob=new st();
            //  ob.displayemp2();
            //  st2 ob2=new st2();
            //  ob2.display ();
            //  st3 dis=new st3();
            //  dis.st3disply();
            //  st4 st4=new st4();
            //  st4.displayst4();
            //  st5 st5= new st5();
            //  st5.st5disply();

            //========================


            //myclass myclass = new myclass();
            //myclass.print();
            //Class1 obj=new Class1();
            //obj.dis();

            //string dbconn = "Server=.;Initial Catalog=Userdatabase;Integrated Security=True;";
            //conncetionstring db=new conncetionstring(dbconn);
            //db.openconncetion();
            //db.closeconncetion();

            //Console.WriteLine("===================Student example==============");
            //Console.WriteLine("enter student id");
            //int id=int.Parse(Console.ReadLine());

            //Console.WriteLine("enter student name :");
            //string name=Console.ReadLine();
            //Console.WriteLine("enter student age");
            //int age = int.Parse(Console.ReadLine());
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
            //student s = new student(id, name, age);
            //s.displaystudent();



        }
    }
 }

