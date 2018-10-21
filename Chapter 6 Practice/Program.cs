using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_6_Practice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       public static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            A a2 = new C();

            string q = "";


            //(1)
            //q += b.m1();
            //q += c.m2();
            //q += a.m3();

            //(2)
            //q += c.m1();
            //q += c.m2();
            //q += c.m3();

            //(3)
            //q += a.m1();
            //q += b.m2();
            //q += c.m3();

            //(4)
            q += a2.m1();
            q += a2.m2();
            q += a2.m3();


            System.Windows.Forms.MessageBox.Show(q);
        }
    }
}
