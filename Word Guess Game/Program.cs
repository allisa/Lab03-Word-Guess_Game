using System;

namespace Word_Guess_Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user, welcome to the Word Guessing Game!");
            //invoke function here for word file creation
            GameMenu();

        }


        /// <summary>
        /// Method for game menu, do behavior based on used input
        /// </summary>
        public static void GameMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please select an option below:");
                Console.WriteLine("0 - Home, 1 - Play, 2 - Word Bank, 3 - Add a Word, 4 - Delete a Word, 5 - Admin, 6 - Exit");
                int optionSelection = Convert.ToInt32(Console.ReadLine());

                switch (optionSelection)
                {
                    case 0:
                        GameMenu();
                        break;
                    case 1:
                        Play();
                        break;
                    case 2:
                        WordBank();
                        break;
                    case 3:
                        Console.WriteLine("Please enter a word to add to the game: ");
                        string wordToAdd = Console.ReadLine();
                        AddWord(wordToAdd);
                        break;
                    case 4:
                        Console.WriteLine("Please enter a word to delete from the game: ");
                        string wordToRemove = Console.ReadLine();
                        RemoveWord(wordToRemove);
                        break;
                    case 5:
                        Admin();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
