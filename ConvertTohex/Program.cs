using System.Text;

namespace ConvertTohex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertToHex("Hello, World!");
        }

        static void ConvertToHex(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            var hex = BitConverter.ToString(bytes).Replace("-", " ").ToLower();
            Console.WriteLine(hex);
        }
    }
}