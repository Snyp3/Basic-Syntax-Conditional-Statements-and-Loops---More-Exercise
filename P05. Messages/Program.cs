using System.Net.WebSockets;

namespace P05._Messages
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int input = int.Parse(Console.ReadLine());
            int letterDigit = 0;
            int countDigit = 0;
            int firstDigit = 0;
            int offSet = 0;
            int totalOffSet = 0;
            int letterIndex = 0;
            string massage = string.Empty;

            for (int i = 1; i <= input; i++)
            {                               
                                                              // от тук -->
                letterDigit = int.Parse(Console.ReadLine());  //string letterDigit
                countDigit = letterDigit.ToString().Length;   //countDigit = letterDigit.Lenght;
                if (letterDigit <= 9)                         //firstDigit = letterDigits[0] - "0";
                {                                             //нещо свързано със ASCII 
                    firstDigit = letterDigit;                 //за намиране на 1вото число
                }                                             //
                else
                {

                    while (letterDigit >= 10)
                    {
                        letterDigit = letterDigit / 10;
                        firstDigit = letterDigit;
                    }
                }                                           // <-- до тук   спестяваме

                if (firstDigit == 0)
                {
                    massage += (char)(firstDigit + 32); // при 0-ла да сложи " "
                    continue;
                }
                else
                {
                    offSet = (firstDigit - 2) * 3;
                }
                if (firstDigit == 8 || firstDigit == 9)
                {
                    offSet++;
                }
                letterIndex = (offSet + countDigit - 1);
                massage += (char)(letterIndex + 97);

            }
            Console.Write(massage);
        }
    }
}