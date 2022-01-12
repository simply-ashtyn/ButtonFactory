﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public static class Input
    {
       // A2
        public static int ReadInteger()
        {
            int number = 0;
            bool isAnumber = false;
            while (isAnumber == false)
            {
                Console.Write("Enter a number: ");
                string num = Console.ReadLine();
                try
                {
                    isAnumber = int.TryParse(num, out number);
                }
                catch (Exception)
                {
                    Console.WriteLine("That is not a valid input, please try again.");
                }
            }
            return number;
        }

        // A3
        public static void ReadString()
        {
            Console.WriteLine();
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input) )
            {
                Console.WriteLine("That is not a valid input, please try again.");
            }
            Console.WriteLine(input);
        }

        // A4
        string[] options = new string[] { "1. The Speech", "2. List of Words", "3. Show Histogram", "4. Search for Word", "5. Remove Word", "6. Exit" };
        public static void ReadChoice(string []  options)
        { 
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine(options[i]);
            }
            Console.Write("\nWhat would you like to do?  ");
            ReadInteger();
        }

        // B1
        public static void GetSpeech()
        {
            string text = "I say to you today, my friends, so even though we face the difficulties of today and tomorrow, I still have a dream. It is a dream deeply rooted in the American dream. " +
                "I have a dream that one day this nation will rise up and live out the true meaning of its creed: We hold these truths to be self-evident: that all men are created equal. " +
                "I have a dream that one day on the red hills of Georgia the sons of former slaves and the sons of former slave owners will be able to sit down together at the table of brotherhood. " +
                "I have a dream that one day even the state of Mississippi, a state sweltering with the heat of injustice, sweltering with the heat of oppression, will be transformed into an oasis of freedom and justice. " +
                "I have a dream that my four little children will one day live in a nation where they will not be judged by the color of their skin but by the content of their character. " +
                "I have a dream today. I have a dream that one day, down in Alabama, with its vicious racists, with its governor having his lips dripping with the words of interposition and nullification; one day right there in Alabama, little black boys and black girls will be able to join hands with little white boys and white girls as sisters and brothers. " +
                "I have a dream today. I have a dream that one day every valley shall be exalted, every hill and mountain shall be made low, the rough places will be made plain, and the crooked places will be made straight, and the glory of the Lord shall be revealed, and all flesh shall see it together. " +
                "This is our hope. This is the faith that I go back to the South with. With this faith we will be able to hew out of the mountain of despair a stone of hope. With this faith we will be able to transform the jangling discords of our nation into a beautiful symphony of brotherhood. " +
                "With this faith we will be able to work together, to pray together, to struggle together, to go to jail together, to stand up for freedom together, knowing that we will be free one day. " +
                "This will be the day when all of God's children will be able to sing with a new meaning, My country, 'tis of thee, sweet land of liberty, of thee I sing. Land where my fathers died, land of the pilgrim's pride, from every mountainside, let freedom ring. " +
                "And if America is to be a great nation this must become true. So let freedom ring from the prodigious hilltops of New Hampshire. Let freedom ring from the mighty mountains of New York. Let freedom ring from the heightening Alleghenies of Pennsylvania! " +
                "Let freedom ring from the snowcapped Rockies of Colorado! Let freedom ring from the curvaceous slopes of California! But not only that; let freedom ring from Stone Mountain of Georgia! " +
                "Let freedom ring from Lookout Mountain of Tennessee! Let freedom ring from every hill and molehill of Mississippi. From every mountainside, let freedom ring. " +
                "And when this happens, when we allow freedom to ring, when we let it ring from every village and every hamlet, from every state and every city, we will be able to speed up that day when all of God's children, black men and white men, Jews and Gentiles, Protestants and Catholics, will be able to join hands and sing in the words of the old Negro spiritual, Free at last! free at last! thank God Almighty, we are free at last!";
            Console.Write(text);
        }
        //B2
        public static void Words()
        {
            char[] delim = new char[] { ' ',',','.','"','+'};
            string[] words = text.Split(delim, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(words);
        }

        //C1
        public static void Dictionary()
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>()
            {
            };
            foreach (var item in word)
            {
                bool isFound = word.ContainsKey(word);
                word.Add();
            }
        }
        public static void WordSearch()
        {
            Console.Write("What word do you want to find? ");
            string search = Console.ReadLine();
        }
}

}
