using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int iLength;
            int iWidth;
            string cont;
            bool valid = true;

            //header
            Console.WriteLine("Room Detail Generator");
            Console.WriteLine("==============================");
            while (valid) {
                //user inputs
                Console.WriteLine("Enter Length:");
                string length = Console.ReadLine();
                while (!(Int32.TryParse(length, out iLength))) {
                    Console.WriteLine("ERROR:Please enter a valid length:");
                    length = Console.ReadLine();
                }
                Console.WriteLine("Enter Width:");
                string width = Console.ReadLine();
                while (!(Int32.TryParse(width, out iWidth))) {
                    Console.WriteLine("ERROR:Please enter a valid width:");
                    width = Console.ReadLine();
                }

                //calcuations and output
                Console.WriteLine("Area: " + (iLength * iWidth));
                Console.WriteLine("Perimeter: " + (2 * (iLength + iWidth)));

                //exit
                Console.WriteLine("Press y to calculate another room or any other key to exit");
                cont = Console.ReadLine();
                if (cont.ToLower() == "y"){
                    valid = true;
                }else {
                    valid = false;
                }

            }
            Console.WriteLine("*******************************");
            Console.WriteLine("Thanks for using my app");
            Console.WriteLine("*******************************");
            Console.ReadKey();
        }
    }
}
