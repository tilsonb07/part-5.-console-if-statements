using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_5.console_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Grade!");

            string grade = Console.ReadLine();
            int condition = Convert.ToInt32(grade);

            if (condition >= 80)
            {



                Console.WriteLine("Good Job!");



            }
            else if (condition <= 79)
            {
                Console.WriteLine("Try for a higher grade!");

            }





            Console.WriteLine("Please guess a number bettween 10-20");

            string number = Console.ReadLine();
            int guess = Convert.ToInt32(number);

            if (guess == 12)


            {
                Console.WriteLine("You guessed it. The number is 12!");
            }
            else if (guess == 11)
            
            {
                Console.WriteLine("Your SO Close!");
            }

            else if (guess == 13)
            {

                Console.WriteLine("Your SO Close!");
            }



            Console.ReadLine();























        }
    }
}
