using System;
using System.Collections.Generic;
using System.Linq;
internal class Program
{
    public static void Main(string[] args)
    {
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        Console.WriteLine("Enter your sentence: ");
        string sentence = Console.ReadLine();
        char[] sentenceArray = sentence.ToCharArray();
        Console.Beep();
        Console.WriteLine("enter the character you want to find the number of occurences of in the given string if all type all");
        string character = (Console.ReadLine());
        character = character.ToLower();
        Console.Beep();
        Dictionary<char, int> occurences = new Dictionary<char, int>();
        char[] charArray = character.ToCharArray();
        //count occurences of each character in the sentence if the character is not in the alphabet then it will not be counted
        if(character == "all")
        {
            for(int i = 0; i < alphabet.Length; i++)
            {
                int count = 0;
                for(int j = 0; j < sentenceArray.Length; j++)
                {
                    if(alphabet[i] == sentenceArray[j])
                    {
                        count++;
                    }
                }
                occurences.Add(alphabet[i], count);
            }
        }
        if (character != "all")
        {
            for (int i = 0; i < charArray.Length; i++)
            {
                if (sentenceArray.Contains(charArray[i]))
                {
                    int frequency = sentence.Count(f => (f == charArray[i]));
                    occurences.Add(charArray[i], frequency);
                }
                else
                {
                    continue;
                }
            }
            foreach (KeyValuePair<char, int> pair in occurences)
            {
                Console.WriteLine("The character {0} appears {1} times in the sentence.", pair.Key, pair.Value);
            }
        }
        Console.ReadLine();
    } 
}
