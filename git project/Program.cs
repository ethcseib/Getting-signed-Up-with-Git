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
            int count = 1;
            Random rand = new Random();

            Console.WriteLine("I am thinking of a number between 0- 100");

            int CorrectAnswer = rand.Next()%100;

            bool val = true;
            

            while (val) {

                string UserAnswer = Console.ReadLine();

                int x = Convert.ToInt32(UserAnswer);
 
                if (x > CorrectAnswer)
                {
                    Console.WriteLine("Answer was too high\n");
                    count++;
                }

                else if (x < CorrectAnswer)
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
