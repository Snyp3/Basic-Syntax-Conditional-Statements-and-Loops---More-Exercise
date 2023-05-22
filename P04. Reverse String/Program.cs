namespace P04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] reverseInput = input.ToCharArray();Array.Reverse(reverseInput);

            string reverse = new string(reverseInput);

            Console.WriteLine(reverse);
            
        }
    }
}