// Licensed to the .NET Foundation under one or more agreements.

namespace stringManipulation
{
    public static class MenuHelpers
    {

        // the main menu references
        public const string Quit = "0";
        public const string SinemaMenu = "1";
        public const string Repeat = "2";
        public const string ThirdWord = "3";

        // the sinema menu references
        public const string SingleTicket = "1";
        public const string GroupTicket = "2";



        public static void ShowMainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("***** The Main Menu *****");
            Console.WriteLine($"{Quit}. Exit the programm");
            Console.WriteLine($"{SinemaMenu}. Display cinema tickets for various age groups and audience categories. ");
            Console.WriteLine($"{Repeat}. Repeat the user input 10 times");
            Console.WriteLine($"{ThirdWord}. Find the third word");
            Console.WriteLine("");

        }

        public static void ShowSinemaMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("***** The Sinema Menu *****");
            Console.WriteLine($"{Quit}. Back to the Main Menu");
            Console.WriteLine($"{SingleTicket}. Display the Single Ticket price ");
            Console.WriteLine($"{GroupTicket}. Display the Group Ticket price");
            Console.WriteLine("");
        }

    }


}
