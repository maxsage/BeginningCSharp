﻿using System;
using System.Runtime.CompilerServices;

namespace _11_04UpgradedCardLib
{
    public class Deck
    {
        private Cards cards = new Cards();

        public Deck()
        {
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards.Add(new Card((Suit) suitVal, (Rank) rankVal));
                }
            }
        }
        
        // Non-default constructor. Allows aces to be set high.
        public Deck(bool isAceHigh) : this()
        {
            Card.isAceHigh = isAceHigh;
        }

        // Non-default constructor. Allows a trump suit to be used.
        public Deck(bool useTrumps, Suit trump) : this()
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }
        
        // Non-default constructor. Allows aces to be set high and a trump suit
        // to be used.
        public Deck(bool isAceHigh, bool useTrumps, Suit trump) : this()
        {
            Card.isAceHigh = isAceHigh;
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }


        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
            {
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and 51."));
            }
        }

        public void Shuffle()
        {
            Cards newDeck = new Cards();
            bool[] assigned = new bool[52];
            for (int i = 0; i < 52; i++)
            {
                int sourceCard = 0;
                bool foundCard = false;
                Random sourceGen = new Random();
                while (foundCard == false)
                {
                    sourceCard = sourceGen.Next(52);
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }

                assigned[sourceCard] = true;
                newDeck.Add(cards[sourceCard]);
            }
            cards = newDeck;
        }
    }
}