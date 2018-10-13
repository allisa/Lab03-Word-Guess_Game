using System;
using System.IO;

namespace Word_Guess_Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello friend, welcome to the Word Guessing Game!");

            string path = "../../../gamewords.txt";

            CreateFile(path);
            ReadFile(path);
            //AppendToFile(path);
            //DeleteLineFromFile(path);


            //GameMenu();

        }


        /// <summary>
        /// Method for game menu, do behavior based on used input
        /// </summary>
        //public static void GameMenu()
        //{
        //    bool exit = false;
        //    while (!exit)
        //    {
        //        Console.WriteLine("Please select an option below:");
        //        Console.WriteLine("0 - Home, 1 - Play, 2 - Word Bank, 3 - Add a Word, 4 - Delete a Word, 5 - Admin, 6 - Exit");
        //        int optionSelection = Convert.ToInt32(Console.ReadLine());

        //        switch (optionSelection)
        //        {
        //            case 0:
        //                GameMenu();
        //                break;
        //            case 1:
        //                Play();
        //                break;
        //            case 2:
        //                WordBank();
        //                break;
        //            case 3:
        //                Console.WriteLine("Please enter a word to add to the game: ");
        //                string wordToAdd = Console.ReadLine();
        //                AddWord(wordToAdd);
        //                break;
        //            case 4:
        //                Console.WriteLine("Please enter a word to delete from the game: ");
        //                string wordToRemove = Console.ReadLine();
        //                RemoveWord(wordToRemove);
        //                break;
        //            case 5:
        //                Admin();
        //                break;
        //            case 6:
        //                exit = true;
        //                break;
        //            default:
        //                Console.WriteLine("Invalid option");
        //                break;
        //        }
        //    }
        //}

        /// <summary>
        /// Method to create starter words in txt file
        /// </summary>
        /// <param name="path"></param>
        public static void CreateFile(string path)
        {
            try
            {
                using (StreamWriter write = new StreamWriter(path))
                    try
                    {
                        string[] starterWords = new string[] { "flamingo", "xanadu", "lavender", "platypus", "mayonaise" };
                        foreach(string index in starterWords)
                        {
                            write.WriteLine(index);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        write.Close();
                    }
            }
            catch (Exception)
            {
                Console.WriteLine("Bad times have found you.");
            }
        }

        /// <summary>
        /// Method to take words from txt file and show them on the console app
        /// </summary>
        /// <param name="path"></param>
        static void ReadFile(string path)
        {
            try
            {
                string[] words = File.ReadAllLines(path);
                Console.WriteLine("Available Game Words:");
                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Error encountered");
            }
        }





    }
}
