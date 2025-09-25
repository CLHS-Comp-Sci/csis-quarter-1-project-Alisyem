using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to PasStore! \nWhat would you like to do? \n[1] Create a password \n[2] Read a password");
        string input = Console.ReadLine();
        while (!input.equals("1") || !input.equals("2")){
            Console.WriteLine("Please input 1 or 2!");
            Console.WriteLine("Welcome to PasStore! \nWhat would you like to do? \n[1] Create a password \n[2] Read a password");
            input = Console.ReadLine();
        }
        if(input.equals("1"))
        {
            
        }
    }

    string GenerablePwd(string[] args)
    {
        //94 Characters
       string[] characters = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "`", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=", "[", "]", ";", "'", ",", ".", "/", @"\", "~", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "{", "}", ":", "\"", "<", ">", "?"] 
       string password = "";
       Random rnd = new Random();

       return password; 
    }
}