using System;
using System.Linq;

namespace _3.__Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputStr = Console.ReadLine();
            string file = inputStr.Substring(inputStr.LastIndexOf('\\') + 1);
            string extension = file.Substring(file.LastIndexOf('.') + 1);
            string fileName = file.Remove(file.LastIndexOf('.'));
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");

        }
    }
}
