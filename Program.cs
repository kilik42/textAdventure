using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
            //then jump right in
            first();
        }

        public static void gameTitle()
        {
            Console.WriteLine("Welcome to my game");
            Console.WriteLine("Press Enter to begin");
            Console.ReadLine();
            Console.Clear();
            
            first();
        }
        public static void first()
        {
            string choice;

            Console.WriteLine("You wake up in class with an angry teacher");
            Console.WriteLine("what do you do?");
            Console.WriteLine("1. punch him");
            Console.WriteLine("2. Cry");
            Console.WriteLine("3. Pee a little");
            Console.WriteLine("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "punch him":
                case "punch":
                    {
                        Console.WriteLine("Your fist hits teacher");
                        Console.WriteLine("all the students in class cheer");
                        Console.WriteLine("Teacher wife hears the commotion and comes out");
                        Console.WriteLine("press enter to continue");
                        Console.ReadLine();
                        gameOver();
                        break;
                        
                    }
                case "2":
                case "cry":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "3":
                case "pee":
                case "pee a little":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        second();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand your command");
                        Console.WriteLine("Press enter to try again");
                        Console.ReadLine();
                        first();
                        break;
                    }

            }
        }
        public static void second()
        {

        }
        public static void third()
        {

        }

        public static void gameOver()
        {

        }
        public static void youWin()
        {

        }
    }
}
