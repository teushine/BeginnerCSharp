using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesApp1
{
    /// <summary>
    /// Playing with Types
    /// </summary>
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Testing t = new Testing();

            Console.WriteLine("Who Test");
            t.WhoTest();

            Console.WriteLine("Back Test");
            t.BackTest();

            Console.WriteLine("OLoad Test");
            t.OLoadTest();

            Console.WriteLine("To String Test");
            t.ToStringTest();

            Console.WriteLine("From String Test");
            t.FromStringTest();

            Console.WriteLine("Check Uncheck Test");
            t.CheckUncheckTest();
        }
    }
}
