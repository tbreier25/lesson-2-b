using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile_1_lab_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int age = 21;
            

            Console.WriteLine("Enter your age : {0}", x);
            if ((x>20) != 0)
            {
                Console.WriteLine("You are of legal age to drink");
            }
            else
            {
                Console.WriteLine("You are too young to drink");
            }
           
            Console.ReadLine();




        }
    }
}
