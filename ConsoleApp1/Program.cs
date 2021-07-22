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
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("hit E to exit");
            Console.WriteLine("and hit any other key to make another calcualtion");
            exitApp();
         
            while (true)
            {
              
                calc();
            }
          

        }


        static void calc()
        {

            //get first number
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            //get operation
            Console.Write("Enter a operation: ");
            char op = Convert.ToChar(Console.ReadLine());

            //get second number
            Console.Write("Enter a another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
       
            switch (op)
            {
                case '*':
                    Console.WriteLine("Your answer is " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Your answer is " + (num1 / num2));
                    break;
                case '+':
                    Console.WriteLine("Your answer is " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Your answer is " + (num1 - num2));
                    break;
                default:
                    Console.WriteLine("Please enter a valid operation");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
            Console.ReadLine();
            
        }
  
        static void exitApp()
        {
            while (Console.ReadKey(true).Key == ConsoleKey.E)
            {
                Console.WriteLine("Thanks for using our app! See you soon");
                for (int i = 0; i < 5; i++)
                {
                    Task.Delay(2000);
                }

                Environment.Exit(0);
                break;
            }
        }

    }
}

