using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word or sentence to test if it is a palindrome:");

            string inputWord = Console.ReadLine();

            inputWord = CleanString(inputWord);

            Console.WriteLine(IsPalindrome(inputWord) ? "That is a palindrome." : "That is not a palindrome");

        }

        static string CleanString(string inputWord)
        {
            string wordToLower = inputWord.ToLower();
            string noWhiteSpace = wordToLower.Replace(" ", "");
            StringBuilder cleanedWord = new StringBuilder();

            foreach (char c in noWhiteSpace)
            {
                if (!Char.IsPunctuation(c))
                {
                    cleanedWord.Append(c);
                }
            }
            return cleanedWord.ToString();
        }


        static bool IsPalindrome(string inputWord)
        {
            if (inputWord == "" || inputWord.Length == 1) return true;

            Stack<char> palStack = new Stack<char>();
            Queue<char> palQueue = new Queue<char>();

            foreach (char c in inputWord)
            {
                palQueue.Enqueue(c);
                palStack.Push(c);
            }
            while (palStack.Count > 0)
            {
                if (palStack.Pop() != palQueue.Dequeue())
                {
                    return false; 
                }
            }
            return true;

        }

    }
}

