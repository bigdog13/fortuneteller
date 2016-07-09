using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {//input questions from user
            Console.WriteLine("What is your first name?");
            String firstname = Console.ReadLine();


            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();


            Console.WriteLine("How old are you?");
          
            int age = int.Parse(Console.ReadLine());
            if (age % 2 == 0)
            {

            }
            



            Console.WriteLine("What month were you born?");
            string year = Console.ReadLine();

            Console.WriteLine("What is your favorite ROYGBIV color enter help to get list? (help)");
            
            string color = Console.ReadLine();
           
           


           
            {
                Console.WriteLine("red", "orange");
                Console.WriteLine("What is your favorite color?");


            }

                Console.ReadLine();
            
            Console.WriteLine("How many siblings do you have?");
           int siblings = int.Parse(Console.ReadLine());
            if (siblings == 0)
            {
                Console.WriteLine("Key West");
            }
            else
              if (siblings == 1)
            {
                Console.WriteLine("Pennsylvania");
            }
            else
              if (siblings == 2)
            { Console.WriteLine("Aruba"); }
            else
              if (siblings == 3)
            {
                Console.WriteLine("Miami");
            }
            else
                 if (siblings == 4 );
            { Console.WriteLine("West Virginia"); }

            { }
            }
        }
    }
