using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for( int i = 0; i < 3; i++)
            {
                pyramid();
            }
            Console.ReadKey();

        }

        static void pyramid() 
        {
            string myName = "#";
            for(int i = 0; i< 7; i++ )
            {
                Console.WriteLine(myName);
                myName += "#";
            }
            for (int i = 0; i <= 7; i++)
            {
                Console.WriteLine(myName);
                myName = myName.Substring(0, myName.Length - 1);
            }
}
    }
}
