using System;
using System.IO;

class Program
{
  static void Main(string[] args)
    {
        bool loop = true;
        while (loop)
        {
            // Initialize character array (94 characters)
            char[] characters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '`', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', '=', '[', ']', ';', '\'', ',', '.', '/', '\\', '~', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '{', '}', '|', ':', '"', '<', '>', '?' };
            Console.WriteLine("Welcome to PasStore! \nWhat would you like to do? \n[1] Create a password \n[2] Read a password");
            string input = Console.ReadLine();
            while (input != "1" && input != "2")
            {
                Console.WriteLine("Please input 1 or 2!");
                input = Console.ReadLine();
            }
            if (input == "1")
            {
                Console.WriteLine("How many characters should your password have? (max of 16)");
                int pIn;
                string pInput = Console.ReadLine();
                while (!int.TryParse(pInput, out pIn) || pIn > 17 || pIn < 0)
                {
                    Console.WriteLine("Please enter a valid number between 1 and 16! Type 0 to exit.");
                    pInput = Console.ReadLine();
                    if (pInput == "0") return;
                }
                string password = "";
                Random rnd = new Random();
                while (pIn > 0)
                {
                    int chara = rnd.Next(0, characters.Length);
                    password += characters[chara];
                    pIn -= 1;
                }
                Console.WriteLine("Great! Your password is: " + password + ". It will now be stored in a file in your Downloads!\nFirst we'll need your PC username.");
                string userName = Console.ReadLine();
                Console.WriteLine("Thank you, " + userName + "! Now we need the name of the desired file! Remember this is in Downloads! (If it does not exist it will be created)");
                string fileName = Console.ReadLine();
                string downloadsPath = @"C:\Users\" + userName + @"\Downloads\" + fileName;
                File.AppendAllText(downloadsPath, password + Environment.NewLine);
                Console.WriteLine("Password has been saved to: " + downloadsPath);
            }
            else
            {
                Console.WriteLine("Of course! Which file would you like to read? Please note this only looks in Downloads.");
                string fileName = Console.ReadLine();
                Console.WriteLine("And what's your username?");
                string userName = Console.ReadLine();
                string filePath = @"C:\Users\" + userName + @"\Downloads\" + fileName;

                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File does not exist in the specified path.");
                }
                else
                {
                    Console.WriteLine("Found file. Here are your passwords:\n");
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            Console.WriteLine("\nPress 0 to restart the program, and anything else to exit.");
            string inFin = Console.ReadLine();
            if (inFin == "0")
            {
                loop = true;
                Console.WriteLine("\nRestarting...\n");
            }
            else
            {
                loop = false;
                Environment.Exit(0);
            }
        }
    }
}