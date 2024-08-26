// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Text;

namespace MyAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row:");
            string? input = Console.ReadLine();

            string? reversed = Anagram.Reverse(input);
            Console.WriteLine("Result:");
            Console.WriteLine(reversed);
            
            Console.ReadLine();
        }
    }
    public class Anagram
    {
       public static string? Reverse(string? input)
       {
            if(input == null)
            {
                return null;
            }
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseWord(words[i]);
            }
            return string.Join(" ", words);
       }
        public static string ReverseWord(string word)
        {
            string[] words = word.Split(' ');
            StringBuilder reversedWord = new StringBuilder();

            foreach (string w in words)
            {
                char[] characters = w.ToCharArray();
                int left = 0;
                int right = characters.Length - 1;

                while (left < right)
                {
                    if (!IsAlphabetic(characters[left]))
                    {
                        left++;
                    }
                    else if (!IsAlphabetic(characters[right]))
                    {
                        right--;
                    }
                    else
                    {
                        char temp = characters[left];
                        characters[left] = characters[right];
                        characters[right] = temp;
                        left++;
                        right--;
                    }
                }

                reversedWord.Append(new string(characters)).Append(" ");
            }

            return reversedWord.ToString().TrimEnd();
        }
        public static bool IsAlphabetic(char ch)
        {
            return char.IsLetter(ch);
        }

        public static int FindWordEndIndex(char[] characters, int startIndex)
        {
            for (int i = startIndex; i < characters.Length; i++)
            {
                if (!IsAlphabetic(characters[i]) && characters[i] != ' ')
                {
                    return i - 1;
                }
            }
            return characters.Length - 1;
        }

    }
}
