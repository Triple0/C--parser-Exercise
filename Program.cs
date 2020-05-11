using System;
using System.IO;

namespace C__parser
{
    class Program
    {
        // A Method that handles both silent running and verbose running of replaceOperation method.
        static void displayOptions(string path)
        {
            if (path == "")
            {
                Console.WriteLine("Error!! No path specified! Kindly select a filename first");
            }
            else
            {
                string oldFileContent = File.ReadAllText(path);
                Console.WriteLine("Instruction: Enter 1 for program to output your operations to screen and 0 not to output, please! NOTE - Only use option 1 if file content is not large!");
                Console.WriteLine("");
                Console.WriteLine("Enter your choice, please: ");
                string displayOptionChoice = Console.ReadLine();


                if (displayOptionChoice == "0") //Handles silent running
                {
                    ReplaceOperation(path);
                }
                else if (displayOptionChoice == "1") //Handles verbose running
                {
                    Console.WriteLine($"File Content: {oldFileContent}");
                    Console.WriteLine("");
                    ReplaceOperation(path);
                    Console.WriteLine(File.ReadAllText(path));
                    Console.WriteLine("");
                }
                else //Handles options that are not correct
                {
                    Console.WriteLine($"Error! Option {displayOptionChoice} selected does not exist!");
                    Console.WriteLine("");
                }
            }
        }

        // A Method that performs replacement operation including reading content from and to specified file.
        static void ReplaceOperation(string path)
        {
            Console.WriteLine("Enter the string to be replaced, please: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Enter the string to replace your string, please: ");
            string userReplaceInput = Console.ReadLine();
            Console.WriteLine("");
            // Reference: https://stackoverflow.com/questions/13509532/how-to-find-and-replace-text-in-a-file-with-c-sharp
            if (File.Exists(path))
            {
                string initialFIleContent = File.ReadAllText(path);
                string finalFileContent = initialFIleContent.Replace(userInput, userReplaceInput);
                File.WriteAllText(path, finalFileContent);

            }
            else
            {
                Console.WriteLine("Warning! File does not exist!! Please enter a valid filename!");
            }
        }

        static void Main(string[] args)
        {
            // Declaring global variables
            string filename = "";
            string path = "";
            string counter = "0";
            while (counter != "3") // initialising a while that only terminates by user input
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
                Console.WriteLine("Enter an option, please: ");
                string option = Console.ReadLine();
                Console.WriteLine("");

                // Handles which operation to be carried out based on users' options
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter your filename, please: ");
                        filename = Console.ReadLine();
                        Console.WriteLine(filename);
                        path = Path.Combine(Environment.CurrentDirectory, filename);
                        break;
                    case "2":
                        displayOptions(path);
                        break;
                    case "3":
                        Console.WriteLine("Option selected will terminate program. Thank you. ");
                        counter = "3";
                        break;
                    default:
                        Console.WriteLine($"Warning! You entered {option}. You can only choice options 1, 2 and 3. Please refer to program instruction. ");
                        Console.WriteLine("");
                        break;

                }
            }


        }
    }
}
