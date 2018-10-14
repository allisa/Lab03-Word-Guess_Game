using System;
using System.IO;
using Xunit;
using Word_Guess_Game;

namespace GuessingGameTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateFile()
        {
            string path = "../../../gamewords.txt";

            Program.CreateFile(path);
            Assert.True(File.Exists("../../../gamewords.txt"));
        }

        [Fact]
        public void CanReadFile()
        {
            string path = "../../../gamewords.txt";
            Assert.NotEmpty(Program.ReadFile(path));
        }

        [Fact]
        public void CanAppendToFile()
        {
            string path = "../../../gamewords.txt";
            string wordToAdd = "autumn";
            Program.AddWordToGame(path, wordToAdd);
            Assert.Contains(wordToAdd, Program.ReadFile(path));
        }

        [Fact]
        public void CanRemoveFromFile()
        {
            string path = "../../../gamewords.txt";
            string wordToRemove = "autumn";
            Program.RemoveWord(path, wordToRemove);
            Assert.DoesNotContain(wordToRemove, Program.ReadFile(path));
        }

    }
}
