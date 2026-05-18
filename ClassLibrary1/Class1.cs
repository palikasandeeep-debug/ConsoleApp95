using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp95;


namespace ClassLibrary1
{
    //public class Class1 : myclass
    //{
    //   public void display()
    //    {
    //        myclass abj=new myclass();
    //       Console.WriteLine( abj.name);

           
    //    }
    //}


      public class pro
    {
        protected int b = 20;
    }
    public class pro2:pro
    {
        public void diplaycurentclass()
        {
            Console.WriteLine(" curent class member" + b);
        }
    }

}
