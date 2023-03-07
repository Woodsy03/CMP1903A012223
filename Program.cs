﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardShuffler
{
    public class DeckGen
    {
        public void Main(string[] args)
        {
            List<string> Numbers = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "King", "Queen", "Ace" };
            List<string> Suites = new List<string>() { "Heart", "Spade", "Club", "Diamond" };

            // Ordered Deck Creation
            List<string> Deck = new List<string>();
            foreach (string x in Suites)
                foreach (string y in Numbers)
                    Deck.Add(y + " of " + x);

            // Prints Shuffled Output
            for (int i = 0; i < Deck.Count; i++)
            {
                Console.WriteLine(Deck[i]);
            }

            
            
        }
    }

    public class ShuffleCardPack
    {
        public static void Main(string[] args)
        {

            // Prompting user for shuffle type
            Console.WriteLine("enter a shuffle type");
            ShuffleCardPack p = new ShuffleCardPack();
            string ShuffleType = Console.ReadLine();

            // choosing shuffle via conditional statment
            if (ShuffleType is "riffle")
            {
                Console.WriteLine("The Riffle shuffle method has been chosen");
                Console.WriteLine("UwU");

                // Splitting the deck
                List<string> FirstHalf = new List<string>();
                List<string> Split = Deck.GetRange(5, 20);
                Console.WriteLine("the split it");
                Console.WriteLine(Split);

                List<string> SecondHalf = new List<string>();




            }
            else
            {
                Console.WriteLine("That isn't a valid shuffle method");
            }




        }
    }
}





