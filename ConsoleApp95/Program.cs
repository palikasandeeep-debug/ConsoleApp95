using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;


namespace ConsoleApp95
{
    //class student
    //{
    //    public void studentdet(ref int id, ref string name, ref int age)
    //    {
    //        Console.WriteLine("student details");
    //        Console.WriteLine("student id" + id);
    //        Console.WriteLine("student name is" + name);
    //        Console.WriteLine("student age" + age);
    //        age = age + 1;
    //        Console.WriteLine("student upadated age" + age);
    //    }
    //    public void studentmarks(int sub1, int sub2, int sub3, out double totmark, out double avg, out double percent)
    //    {
    //        totmark = sub1 + sub2 + sub3;
    //        avg = totmark / 3.0;
    //        percent = (totmark / 300.0) * 100;
    //    }
    //}



        //class employee
        //{
        //    int empid;
        //    string name;
        //    double sal;
        //    public employee(int empid, string name, double sal)
        //    {
        //        this.empid = empid;
        //        this.name = name;
        //        this.sal = sal;



        //    }

        //    public void calnetsal()
        //    {
        //        double hra = sal + 0.20;
        //        double da = sal + 0.15;
        //        double pf = sal + 0.10;
        //        double netsal = hra + da + pf;
        //        Console.WriteLine("id is:" + empid);
        //        Console.WriteLine("name is:" + name);
        //        Console.WriteLine("sal is:" + sal);
        //        Console.WriteLine("net sal is" + netsal);
        //    }


        //}


















        //class calculation
        //{
        //    public void add(int a, int b)
        //    {
        //        int c = a + b;
        //        Console.WriteLine("addition two integer is:" + c);
        //    }
        //    public void add(int a, int b, int c)
        //    {
        //        int d = a + b + c;
        //        Console.WriteLine("addition of 3 integer is:" + d);
        //    }
        //    public void add(double a, double b)
        //    {
        //        double c = a + b;
        //        Console.WriteLine("addition of two double is:" + c);


        //    }
        //    public void add(double a, double b, double c)
        //    {
        //        double d = a + b + c;
        //        Console.WriteLine("addition of 3 double:" + d);
        //    }
        //    public void add(int age, string name)
        //    {
        //        Console.WriteLine($"name is {name} age is {age}");
        //    }
        //    public void add(string name, int age)
        //    {
        //        Console.WriteLine($"name is {name}age is{age}");
        //    }


        //}


        //class employee
        //{
        //    public string name;

        //    public void login()
        //    {
        //        Console.WriteLine("log in successful");


        //    }

        //}
        //class developer : employee
        //{
        //    public void writecode()
        //    {
        //        Console.WriteLine("developer writing code ");
        //    }
        //}
        //class testing : employee
        //{
        //    public void testingcode()
        //    {
        //        Console.WriteLine("testing code");
        //    }


        //}







        //   interface IAudit
        //    {
        //       void auditinfo();
        //    }

        //class Headoffice
        //{
        //    protected string headloc;
        //    protected ulong headphn;

        //    public Headoffice(string headloc, ulong headphn)
        //    {
        //        this.headloc = headloc;
        //        this.headphn = headphn;

        //    }
        //    public void HeadDisplay()
        //    {
        //        Console.WriteLine("Headofiice office location:" + headloc);
        //        Console.WriteLine("headoffice phone number:" + headphn);

        //    }
        //}
        //class Branch : Headoffice
        //{
        //    int branchid;
        //    string branchname;
        //    public Branch(int branchid, string branchname, string headloc, ulong headphn) : base(headloc, headphn)
        //    {
        //        this.branchid = branchid;
        //        this.branchname = branchname;


        //    }

        //    public void BranchDisplay()
        //    {

        //        Console.WriteLine("branch id is:" + branchid);
        //            Console.WriteLine("branch name is:" + branchname);
        //            base.HeadDisplay();
        //    }



        //}



        //class employee :Branch, IAudit
        //{

        //    int eno;
        //    string ename;
        //    public employee(int eno, string ename, int branchid, string branchname, string headloc, ulong headphn) : base(branchid, branchname, headloc, headphn)
        //    {
        //        this.eno = eno;
        //        this.ename = ename;
        //    }

        //    public void EmployeeDisplay()
        //    {
        //        Console.WriteLine("emp no is:" + eno);
        //        Console.WriteLine("emp name is:" + ename);
        //        base.BranchDisplay();
        //    }
        //    public void auditinfo()
        //    {
        //        Console.WriteLine("employeed verified");

        //    }
        //}



































        //class Account
        //{

        //    private double balance;
        //    private string pin;


        //    public string Pin
        //    {
        //        get { return pin; }
        //        set { pin = value; }
        //    }


        //    public Account(double b, string p)
        //    {
        //        balance = b;
        //        Pin = p;
        //    }


        //    public void Deposit(double amount)
        //    {
        //        if (amount > 0)
        //        {
        //            balance += amount;

        //            Console.WriteLine("Deposited Amount: " + amount);
        //            Console.WriteLine("Current Balance: " + balance);
        //        }
        //    }


        //    public void Withdraw(double amount)
        //    {
        //        Console.Write("Enter PIN: ");

        //        string enteredPin = Console.ReadLine();

        //        if (enteredPin != Pin)
        //        {
        //            Console.WriteLine("Invalid PIN");
        //            return;
        //        }

        //        if (amount <= balance)
        //        {
        //            balance -= amount;

        //            Console.WriteLine("Withdraw Amount: " + amount);
        //            Console.WriteLine("Remaining Balance: " + balance);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Insufficient Balance");
        //        }
        //    }


        //    public void ShowBalance()
        //    {
        //        Console.WriteLine("Available Balance: " + balance);
        //    }
        //}










        //OOps Princeples


        //encapuslation



        //class account
        //{
        //    private double balance;
        //    private string pin;
        //    public account(double amount, string p)
        //    {
        //        balance = amount;
        //        pin = p;
        //    }
        //    public void Deposit(double amount)
        //    {
        //        if (amount > 0)
        //        {
        //            balance += amount;
        //        }
        //        Console.WriteLine("deposit amount: "+balance);
        //    }
        //    public void withdraw(double amount)
        //    {
        //        Console.WriteLine(" enter pin ");
        //        string enterpin =Console.ReadLine();
        //        if (enterpin !=pin)
        //        {
        //            Console.WriteLine(" in valid pin");
        //           return;

        //        }
        //        else if (amount <= balance)
        //        {
        //            balance -= amount;

        //            Console.WriteLine("withdraw amount: " + amount);
        //        }

        //    }
        //    public double getbalance()
        //    {
        //        return balance;
        //    }

        //}



















        //class employee
        //{
        //    int id;
        //    string name;
        //    double sal;
        //    static string companyname;
        //    public employee(int eid, string ename, double esal)
        //    {
        //        id = eid;
        //        name = ename;
        //        sal = esal;
        //    }
        //    static employee()
        //    {
        //        companyname = "wipro";
        //    }
        //    public void displayempdetais()
        //    {
        //        Console.WriteLine("emp id is:  " + id);
        //        Console.WriteLine("emp name is : " + name);
        //        Console.WriteLine("emp sal is : " + sal);
        //    }
        //    public static void company()
        //    {
        //        Console.WriteLine("company name is : " + companyname);
        //    }
        //    public void  hikesal()
        //    {
        //        double hikesal = sal * 10 / 100;
        //        Console.WriteLine("hikesal is: "+hikesal);
        //          }

        //}















        //class student
        //{
        //    int sid;
        //    string Sname;
        //    static string collegename;

        //    public student(int Sid, string sname)
        //    {
        //        sid = Sid;
        //        Sname = sname;
        //    }
        //    static student()
        //    {
        //        collegename = "cdc";

        //    }

        //    public void display()
        //    {
        //        Console.WriteLine("student id is: " + sid);
        //        Console.WriteLine("student name is: " + Sname);
        //    }
        //    public static void collegedisplay()
        //    {

        //        Console.WriteLine("college name is: " + collegename);
        //    }
        //}












        // copy constractor:
        //class student
        //{

        //    public int Sid;
        //    public string Sname;

        //    public student(int sid, string sname)
        //    {
        //        Sid = sid;
        //        Sname = sname;
        //    }
        //    public student(student st)
        //    {
        //        Sid = st.Sid;
        //        Sname = st.Sname;
        //    }
        //    public void StudentDisplay()
        //    {

        //        Console.WriteLine("student id is:  " + Sid);
        //        Console.WriteLine("Student Name is:  " + Sname);
        //    }
        //}

































        //class student
        //{
        //    int sid;
        //    string name;

        //    public student(int sid, string name)
        //    {
        //        this.sid = sid;
        //        this.name = name;
        //    }
        //    public void display()
        //    {
        //        Console.WriteLine("Student id is:" + sid);
        //        Console.WriteLine("Student name is:" + name);
        //    }
        //}










        //public class protectd
        //  {
        //      public void displaypro()

        //      {
        //          testingprotected t=new testingprotected();
        //          Console.WriteLine("protected testing" +t. c);
        //      }

        //  }


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

               par p=new par();
            p.img();
            p.video();

                //student calclutation marks 
                //Console.WriteLine("enter student id");
                //int id = int.Parse(Console.ReadLine());
                //Console.WriteLine("enter student name");
                //string name = Console.ReadLine();
                //Console.WriteLine("enter student age");
                //int age = int.Parse(Console.ReadLine());
                //Console.WriteLine("enter fist subject marks");
                //int sub1 = int.Parse(Console.ReadLine());
                //Console.WriteLine("enter second subject marks");
                //int sub2 = int.Parse(Console.ReadLine());
                //Console.WriteLine("enter third subject marks");
                //int sub3 = int.Parse(Console.ReadLine());
                //student s1 = new student();
                //s1.studentdet(ref id, ref name, ref age);
                //double tot;
                //double avg, per;
                //s1.studentmarks(sub1, sub2, sub3, out tot, out avg, out per);
                //Console.WriteLine("total is" + tot);
                //Console.WriteLine("avg is" + avg);
                //Console.WriteLine("percentis" + per+"%");









                //05/06/26


                //try
                //{
                //    Console.WriteLine("enter fist number");
                //    int a = Convert.ToInt32(Console.ReadLine());
                //    Console.WriteLine("enter second Number");
                //    int b = Convert.ToInt32(Console.ReadLine());
                //    int c = a / b;
                //    Console.WriteLine("dive result is" + c);

                //}
                //catch (DivideByZeroException )
                //{
                //    Console.WriteLine("denominator cannot be zero");

                //}
                //catch (FormatException )
                //{

                //    Console.WriteLine("pls enter  only integer");
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("exception accured" + ex.Message);
                //}











                //employee e = new employee(111, "sandy", 10000);
                //e.calnetsal();




















                //3/06/2026:
                //hirarical

                //  employee obj=new employee(111,"rama",123,"abc","hyd",04012345);
                // obj.EmployeeDisplay();
                //obj.auditinfo();
                //=========================

                //developer dev = new developer();
                //dev.writecode();
                //dev.login();
                //testing test = new testing();
                //test.testingcode();
                //test.login();

                // -----------------------
                //polymophism
                //       calculation cal = new calculation();
                //       cal.add(10, 20);
                //       cal.add(10, 20, 30);
                //       cal.add(0.5, 0.5);
                //       cal.add(0.5, 0.5, 0.5);
                //cal.add(25, "sandy");
                //       cal.add("sandy", 26);





































                //Console.Write("Enter initial balance: ");
                //double b = Convert.ToDouble(Console.ReadLine());

                //Console.Write("Set pin: ");
                //string p = Console.ReadLine();


                //Account acc = new Account(b, p);

                //Console.Write("Enter deposit amount: ");
                //double depositAmount = Convert.ToDouble(Console.ReadLine());

                //acc.Deposit(depositAmount);

                //Console.Write("Enter withdraw amount: ");
                //double withdrawamount = Convert.ToDouble(Console.ReadLine());

                //acc.Withdraw(withdrawamount);

                //acc.ShowBalance();

























                //27/05/2026
                // Encapslation
                //account ac = new account(5000, "anil123");
                //ac.Deposit(6000);
                //    ac.withdraw(2000);
                //Console.WriteLine("balance amount: " + ac.getbalance());





                //employee e = new employee(1, "rama", 1000);

                //   e.displayempdetais();
                //employee.company();
                //e.hikesal();    









                //student s1 = new student(1, "rama");
                //s1.display();
                //student s2 = new student(2, "ravi");
                //s2.display();
                //student.collegedisplay();








                //copy constructor
                //student obj = new student(1, "sandy");
                //obj.StudentDisplay();
                //student sobj = new student(obj);
                //sobj.StudentDisplay();
























                //Console.WriteLine("how many students details U want enter");
                //int n = int.Parse(Console.ReadLine());
                //student[] st = new student[n];
                //Console.WriteLine("enter student details");
                //for (int i = 0; i < n; i++)
                //{
                //    Console.WriteLine("enter student id");
                //    int id = int.Parse(Console.ReadLine());
                //    Console.WriteLine("Enter Student Name");
                //    string name = Console.ReadLine();
                //    st[i] = new student(id, name);
                //}

                //Console.WriteLine("Student Details are");
                //for (int i = 0; i < st.Length; i++)
                //{
                //    st[i].display();
                //}












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


