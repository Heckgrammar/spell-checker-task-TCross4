using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System;

namespace SpellCheckerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = createDictionary();
        Console.WriteLine("Input a word.");
        string word = Console.ReadLine();
        bool valid = false;
        int count = 0;
        int right = 0;
        int wrong = 0;
        while (valid == false)
        {
            if (dictionayData[count] == word)
            {
                valid = true;
            }
            count++;
        }
        Console.WriteLine(valid);
        if (valid == false)
        {
            wrong++;
            WordsFile.txt(word);
        }
        else
        {
            right++
        }
        string[] words2 = new string[3];
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Input a word.");
            words2[i] = Console.ReadLine;
        }
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;
        while(valid1 == false && valid2 == false && valid3 == false)
        {
            if (dictionayData == words2[0])
            {
                valid1 = true;
            }
            else if (dictionayData == words2[1])
            {
                valid2 = true;
            }
            else if (dictionayData == words2[2])
            {
                valid3 = true;
            }
        }
        Console.WriteLine(valid1 + valid2 + valid3);
        if (valid1 == false)
        {
            wrong++;
            WordsFile.txt(words2[0]);
        }
        else if (valid2 == false)
        {
            wrong++;
            WordsFile.txt(words2[1]);
        }
        else if (valid3 == false)
        {
            wrong++;
            WordsFile.txt(words2[2]);
        }
        if (valid1 == true)
        {
            right++;
        }
        else if (valid2 == true)
        {
            right++;
        }
        else if (valid3 == true)
        {
            right++;
        }
        Console.WriteLine(right / (right + wrong) * 100 + "%");
            //1. Take a user input of a word an check if it has been spelled correctly

            //2. Take a string of words as a user input and check they have all been spelled correctly

            //3.Create a spelling score based on the percentage of words spelled correctly

            //4.Create a new list of words that have been spelled incorrectly and save it in a new file

            //Challenge - Hard task

            //Try to work out which words the user is trying to spell by looking for similarities in
            //the spelling and ask the user did they mean that.

            //Add these suggested words to a spelling list that the user can save as a file to work on
            //their own spelling

    }
    static string[] createDictionary()
        {
            using StreamReader words = new("WordsFile.txt");
            int count = 0;
            string[] dictionaryData = new string[178636];
            while (!words.EndOfStream)
            {
                dictionaryData[count] = words.ReadLine();
                count++;
            }
            words.Close();
            return dictionaryData;
        }
    }
}
