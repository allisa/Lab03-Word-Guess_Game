﻿using System;
using System.IO;

namespace Word_Guess_Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello friend, welcome to the Word Guessing Game!");

            string path = "../../../gamewords.txt";

            CreateFile(path);
            GameMenu(path);

        }
        
        /// <summary>
        /// Method for game menu, do behavior based on used input
        /// </summary>
        public static void GameMenu(string path)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please select an option below:");
                Console.WriteLine("0: Home, 1: Play, 2: Word Bank, 3: Add a Word, 4: Delete a Word, 5: Exit");
                int optionSelection = Convert.ToInt32(Console.ReadLine());

                switch (optionSelection)
                {
                    case 0:
                        GameMenu(path);
                        break;
                    case 1:
                       // Play();
                        break;
                    case 2:
                        ReadFile(path);
                        break;
                    case 3:
                        Console.WriteLine("Please enter a word to add to the game: ");
                        string wordToAdd = Console.ReadLine();
                        AddWordToGame(path, wordToAdd);
                        break;
                    case 4:
                        Console.WriteLine("Please enter a word to delete from the game: ");
                        string wordToRemove = Console.ReadLine();
                        RemoveWord(path, wordToRemove);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

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
        public static string[] ReadFile(string path)
        {
            try
            {
                string[] words = File.ReadAllLines(path);
                Console.WriteLine("Available Game Words:");
                foreach(string word in words)
                {
                    Console.WriteLine(word);
                }
                return words;

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to add a word to the game after user selects to add word from game menu
        /// </summary>
        /// <param name="path"></param>
        /// <param name="wordToAdd"></param>
        public static void AddWordToGame(string path, string wordToAdd)
        {

            using (StreamWriter sw = File.AppendText(path))
            {
                try
                {
                    sw.WriteLine(wordToAdd);
                    Console.WriteLine("Word has been added to the game");
                }
                catch (Exception)
                {
                    Console.WriteLine("An error has a found way into your life");
                }
            }
        }

        /// <summary>
        /// Method to remove word entered by user after prompt from user menu
        /// Help received from Danul De Leon to correctly remove word and update file
        /// </summary>
        /// <param name="path"></param>
        /// <param name="wordToRemove"></param>
        public static void RemoveWord(string path, string wordToRemove)
        {
            try
            {
                string[] currentWords = ReadFile(path);
                int indexOfWord = Array.IndexOf(currentWords, wordToRemove);
                string[] newWords = new string[currentWords.Length - 1];

                for (int i = 0; i < currentWords.Length; i++)
                {
                    if (i == indexOfWord)
                    {
                        continue;
                    }
                    else if (i < indexOfWord)
                    {
                        newWords[i] = currentWords[i];
                    }
                    else
                    {
                        newWords[i - 1] = currentWords[i];
                    }
                }
                File.WriteAllLines(path, newWords);
                Console.WriteLine($"The word you requested to remove, {wordToRemove}, had been deleted.");
            }
            catch (Exception)
            {
                Console.WriteLine("Error has occured");
            }
        }

        /// <summary>
        /// Method to choose random word from word bank file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string RandomWord(string path)
        {
            Random random = new Random();
            string[] wordArray = File.ReadAllLines(path);
            int randIndex = random.Next(wordArray.Length);
            string randomWord = wordArray[randIndex];
            return randomWord;
        }


        public static void Play(string path, int randomWord)
        {
           //stopping because I'm confused and need to do other life things
           //still need to figure out:
           //make random word show up as _
           //get user guess
           //check user guess for matching letters in random word chosen
           //change _ to letter if match
           //show guessed letters
           //show score?

        }



    }
}
