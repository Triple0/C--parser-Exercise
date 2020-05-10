using System;
using System.IO;

namespace C__parser
{
    class Program
    {
        static void displayOptions(string filename)
        {
            string oldFileContent = File.ReadAllText("filename.txt");
            Console.WriteLine("Instruction: Enter 1 for program to output your operations to screen and 0 not to output, please! NOTE - Only use option 1 if file content is not large!");
            Console.WriteLine("");
            Console.WriteLine("Enter your choice, please: ");
            Console.WriteLine("");
            string displayOptionChoice = Console.ReadLine();

            if (displayOptionChoice == "0")
            {
                ReplaceOperation(filename);
            }
            else if (displayOptionChoice == "1")
            {
                Console.WriteLine($"File Content: {oldFileContent}");
                Console.WriteLine("");
                ReplaceOperation(filename);
                Console.WriteLine(File.ReadAllText("filename.txt"));
            }
            else
            {
                Console.WriteLine($"Error! Option {displayOptionChoice} selected does not exist!");
            }
        }

        static void ReplaceOperation(string filename)
        {
            Console.WriteLine("Enter your string, please: ");
            string userInput = Console.ReadLine();
            // Reference: https://stackoverflow.com/questions/13509532/how-to-find-and-replace-text-in-a-file-with-c-sharp
            if (File.Exists(filename))
            {
                string initialFIleContent = File.ReadAllText(filename);
                string finalFileContent = initialFIleContent.Replace(userInput, "");
                File.WriteAllText(filename, finalFileContent);

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
                string filename = "filename.txt";
                string option = Console.ReadLine();  


                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter your filename, please: ");
                        //filename = Console.ReadLine();
                        break;
                    case "2":
                        displayOptions(filename);
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
