using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            bool val = true;
            int count = 1;
            Random rand = new Random();

            Console.WriteLine("Pick two numbers one starting number and one ending number");

            string convert = Console.ReadLine();
            x = Convert.ToInt32(convert);

            convert = Console.ReadLine();
            y = Convert.ToInt32(convert);

            Console.WriteLine("I am thinking of a number between " + Convert.ToString(x) + " and " + Convert.ToString(y));
            
            
            int CorrectAnswer = rand.Next(x, y);

            while (val) {

                string UserAnswer = Console.ReadLine();

                int integer = Convert.ToInt32(UserAnswer);
 
                if (integer > CorrectAnswer)
                {
                    Console.WriteLine("Answer was too high\n");
                    count++;
                }

                else if (integer < CorrectAnswer)
                {
                    Console.WriteLine("Answer was too low\n");
                    count++;
                }

                else
                {
                    Console.WriteLine("Correct! Your total tries were " + Convert.ToString(count) + "\n");
                    val = false;
                }
                
            }

            Console.ReadKey();
        }
    }
}
