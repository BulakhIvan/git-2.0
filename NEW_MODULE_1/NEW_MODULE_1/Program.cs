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
            
            for (int i = 0; i < numb_toConvert.Length; i++)
            {
                if (numb_toConvert[i] % 2 == 0)
                {
                    int o = 0;
                    evenNumb[o] = numb_toConvert[i];
                    o++;
                }
                else
                {
                    int o = 0;
                    oddNumb[o] = numb_toConvert[i];
                    o++;
                }// расделления на четные

            }
            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] evenLetters = new string[lenghtEvenArray];
            string[] oddLetters = new string[lenghtEvenArray];
            for (int i = 0; i < evenNumb.Length; i++)
            {
                int o = evenNumb[i];
                evenLetters[i] =alphabet[o];
            }
            for(int i = 0; i < oddNumb.Length; i++)
            {
                int o = oddNumb[i];
                oddLetters[i] = alphabet[o];
            }//замена цифр

            for (int i = 0; i < evenLetters.Length; i++)
            {
                evenLetters[i] = evenLetters[i].Replace('a', 'A');
                evenLetters[i] = evenLetters[i].Replace('e', 'E');
                evenLetters[i] = evenLetters[i].Replace('i', 'I');
                evenLetters[i] = evenLetters[i].Replace('d', 'D');
                evenLetters[i] = evenLetters[i].Replace('h', 'H');
                evenLetters[i] = evenLetters[i].Replace('j', 'J');
            }
            for (int i = 0; i < oddLetters.Length; i++)
            {
                oddLetters[i] = oddLetters[i].Replace('a', 'A');
                oddLetters[i] = oddLetters[i].Replace('e', 'E');
                oddLetters[i] = oddLetters[i].Replace('i', 'I');
                oddLetters[i] = oddLetters[i].Replace('d', 'D');
                oddLetters[i] = oddLetters[i].Replace('h', 'H');
                oddLetters[i] = oddLetters[i].Replace('j', 'J');
            }// up letters
            int upperEvenLetter = 0;
            int upperOddLetter = 0;
            for (int i = 0; i<evenLetters.Length; i++)
            {
                if (evenLetters[i]=="D")
                {
                    upperEvenLetter = upperEvenLetter + 1;
                }
                if (evenLetters[i] == "H")
                {
                    upperEvenLetter = upperEvenLetter + 1;
                }
                if (evenLetters[i] == "J")
                {
                    upperEvenLetter = upperEvenLetter + 1;
                }

            }
            for (int i = 0; i < oddLetters.Length; i++)
            {
                if (oddLetters[i] == "A")
                {
                    upperOddLetter = upperOddLetter + 1;
                }
                if (evenLetters[i] == "E")
                {
                    upperEvenLetter = upperEvenLetter + 1;
                }
                if (evenLetters[i] == "I")
                {
                    upperEvenLetter = upperEvenLetter + 1;
                }
            }
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
