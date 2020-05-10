using System;
using System.IO;

namespace C__parser
{
    class Program
    {
        static void ReplaceOperation(string filename) {
            Console.WriteLine("Enter your string, please: "); 
                string userInput = Console.ReadLine();
                if ( File.Exists( filename ) ) {
                    string initialFIleContent = File.ReadAllText( filename );
                    string finalFileContent = initialFIleContent.Replace( userInput, "");
                    File.WriteAllText(filename, finalFileContent);
                    Console.WriteLine($"New file content: {finalFileContent}");                  
                } else {
                    Console.WriteLine("Warning! File does not exist!! Please enter a valid filename!");
                } 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*                      Welcome to C# Parser                                *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*                         Menu options:                                    *");
            Console.WriteLine("*                  Select 1 to enter a filename                            *");
            Console.WriteLine("*                    Select 2 to enter a word                              *");
            Console.WriteLine("*                   Select 3 to terminate/exit                             *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Welcome. Enter an option, please: ");
            string filename = "filename.txt";
            string option = Console.ReadLine();
            int counter = 0;
            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);
            // Console.WriteLine(typeof(readText));
            switch(option) {
                case "1":
                Console.WriteLine("Enter your filename, please: "); 
                //filename = Console.ReadLine();
                break;
                case "2":
                    ReplaceOperation(filename);           
                    break;
                case "3":
                counter = 3;
                break;
                default: 
                break;

            }


        }
    }
}
