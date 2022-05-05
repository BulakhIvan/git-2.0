using System;
using System.Linq;
using System.Text;

namespace NEW_MODULE_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N=");
            int N =Convert.ToInt32(Console.ReadLine());
            int[] numb_toConvert = new int[N];
            Random random = new Random();
            for (int i = 0; i < numb_toConvert.Length; i++)
            {
                numb_toConvert[i] = random.Next(0,25);
            } // creat array
            int lenghtEvenArray = 0;
            int lenghtOddArray = 0;
            for (int i = 0; i < numb_toConvert.Length; i++)
            {
                if (numb_toConvert[i] % 2 == 0)
                {
                    lenghtEvenArray=lenghtEvenArray + 1;
                }
               
            }// lenght arrays
            int[] evenNumb = new int[lenghtEvenArray];
            int[] oddNumb = new int[lenghtOddArray];
            int odd = 0;
            int even = 0;
            for (int i = 0; i < numb_toConvert.Length; i++)
            {
                if (numb_toConvert[i] % 2 == 0)
                {
                    
                    evenNumb[even] = numb_toConvert[i];
                    even ++;
                }
                else
                {
                    
                    oddNumb[odd] = numb_toConvert[i];
                  odd++;
                }// division into even

            }
            //string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] evenLetters = new string[lenghtEvenArray];
            string[] oddLetters = new string[lenghtEvenArray];
            for (int i = 0; i < evenNumb.Length; i++)
            {
                evenLetters[i] = Convert.ToString(Convert.ToChar(evenNumb[i]+97));
            }
            for(int i = 0; i < oddNumb.Length; i++)
            {
                oddLetters[i] = Convert.ToString(Convert.ToChar(evenNumb[i] + 97));
            }//change numb
            string [] forUpper = { "a", "e", "i", "d", "h", "j" };
            for (int i = 0; i < evenLetters.Length; i++)
            {
                for (int j = 0; j < forUpper.Length; j++)
                {
                    if(evenLetters[i] == forUpper[j])
                    {
                        evenLetters[i] = evenLetters[i].ToUpper();
                    }
                }
            }
            for (int i = 0; i < oddLetters.Length; i++)
            {
                for (int j = 0; j < forUpper.Length; j++)
                {
                    if (oddLetters[i] == forUpper[j])
                    {
                        oddLetters[i] = oddLetters[i].ToUpper();
                    }
                }
            }// up letters
            int upperEvenLetter = 0;
            int upperOddLetter = 0;
            string[] UpperLetters = { "A", "E", "I", "D", "H", "J" };
            for (int i = 0; i<evenLetters.Length; i++)
            {
               for (int j = 0; j < forUpper.Length; j++)
               {
                    if(evenLetters[i] == UpperLetters[j])
                    {
                        upperEvenLetter++;
                    }
               }

            }
            for (int i = 0; i < oddLetters.Length; i++)
            {
                for (int j = 0; j < forUpper.Length; j++)
                {
                    if (oddLetters[i] == UpperLetters[j])
                    {
                        upperOddLetter++;
                    }
                }
            } //how in upper
            if (upperEvenLetter > upperOddLetter)
            {
                Console.WriteLine("четных букв в верхнем регистре больше " + upperEvenLetter);
            }
            else
                Console.WriteLine("нечетных букв в верхнем регистре больше " + upperOddLetter);
            Console.WriteLine("odd Letters" );
            foreach (string i in oddLetters)
            {
                Console.WriteLine(i+" ");
            }
            Console.WriteLine("even Letters");
            foreach (string i in evenLetters)
            {
                Console.WriteLine(i + " ");
            }

        }
    }
}
