using System;
using System.IO;

namespace C__parser
{
    class Program
    {
        static void displayOptions(string path)
        {
            Console.WriteLine(path);
            string oldFileContent = File.ReadAllText(path);
            Console.WriteLine("Instruction: Enter 1 for program to output your operations to screen and 0 not to output, please! NOTE - Only use option 1 if file content is not large!");
            Console.WriteLine("");
            Console.WriteLine("Enter your choice, please: ");
            string displayOptionChoice = Console.ReadLine();

            if (displayOptionChoice == "0")
            {
                ReplaceOperation(path);
            }
            else if (displayOptionChoice == "1")
            {
                Console.WriteLine($"File Content: {oldFileContent}");
                Console.WriteLine("");
                ReplaceOperation(path);
                Console.WriteLine(File.ReadAllText(path));
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"Error! Option {displayOptionChoice} selected does not exist!");
                Console.WriteLine("");
            }
        }
        static void ReplaceOperation(string path)
        {
            Console.WriteLine("Enter the string to be replaced, please: ");
            string userInput = Console.ReadLine();
            // Reference: https://stackoverflow.com/questions/13509532/how-to-find-and-replace-text-in-a-file-with-c-sharp
            if (File.Exists(path))
            {
                string initialFIleContent = File.ReadAllText(path);
                string finalFileContent = initialFIleContent.Replace(userInput, "");
                File.WriteAllText(path, finalFileContent);

            }
            else
            {
                Console.WriteLine("Warning! File does not exist!! Please enter a valid filename!");
            }
        }

        static void Main(string[] args)
        {
            string counter = "0";
            while (counter != "3")
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
                string option = Console.ReadLine();
                Console.WriteLine(""); 
                string filename = "filename.txt";
                string path = @"C:\Users\Olalekan\Documents\TechCareer\Assignment\C#-parser\filename.txt"; 

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter your filename, please: ");
                        filename = Console.ReadLine();
                        Console.WriteLine(filename);
                        path = Path.Combine(Environment.CurrentDirectory, filename);    
                        break;
                    case "2":
                    Console.WriteLine(path); 
                        displayOptions(path);
                        break;
                    case "3":
                        Console.WriteLine("Option selected will terminate program. Thank you. ");
                        counter = "3";
                        break;
                    default:
                        break;

                }
            }


        }
    }
}
