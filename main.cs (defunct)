using System;
using System.IO;

public MainClass
{
    class Main(string[] args)
    {
        Console.WriteLine("Welcome to PasStore! \nWhat would you like to do? \n[1] Create a password \n[2] Read a password");
        string input = Console.ReadLine();
        while (!input.equals("1") || !input.equals("2")){
            Console.WriteLine("Please input 1 or 2!");
            Console.WriteLine("Welcome to PasStore! \nWhat would you like to do? \n[1] Create a password \n[2] Read a password list?");
            input = Console.ReadLine();
        }
        if(input.equals("1"))
        {
            Console.WriteLine("How many characters should your password have? (max of 16)"); 
            int pInput = Console.ReadLine();
            while(pInput > 16) 
            { 
                Console.WriteLine("Sorry, we only support a maximum of 16 characters! Type 0 to exit.");
                Console.WriteLine("How many characters should your password have? (Max of 16)"); 
                pInput = Console.ReadLine();
                if(pInput <= 0)
                {
                    break;
                }
            }    
            //Somehow call GenerablePass, with the pInput

        }
    }

    public static string GenerablePass(string[] args)
    {
        //94 Characters
        char[] characters = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '`', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', '=', '[', ']', ';', '\'', ',', '.', '/', '\\', '~', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '{', '}', '|', ':', '"', '<', '>', '?'};
        string password = "";
        while(pInput > 0)
        {
            Random rnd = new Random();
            int chara  = rnd.Next(0, 93);
            password += characters[chara];
            pInput -= 1;
        }
        return password; 
    }
}
