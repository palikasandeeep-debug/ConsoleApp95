using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class testingprotected
    {
        protected internal  int c = 10;
    }
    public class test2
    {
        testingprotected t=new testingprotected();
        public void display()
        {
            Console.WriteLine("display" +t. c);
        }
    }

}
