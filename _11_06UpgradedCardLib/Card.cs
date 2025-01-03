﻿using System;
using System.Diagnostics.Eventing.Reader;

namespace _11_06UpgradedCardLib
{
    public enum Suit
    {
        Club,
        Diamond,
        Heart,
        Spade
    }

    public enum Rank
    {
        Ace = 1,
        Deuce,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public class Card : ICloneable
    {
        // Flag for trump usage. If true, trumps are valued higher
        // than cards of other suits.
        public static bool useTrumps = false; 
        
        //Trump suit to use if useTrumps is true.
        public static Suit trump = Suit.Club;
        
        // Flag that determines whether Aces are higher than Kings or lower 
        // than deuces
        public static bool isAceHigh = true;
        
        public readonly Suit suit;

        public readonly Rank rank;

        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }

        private Card()
        {
        }
        
        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public static bool operator ==(Card card1, Card card2)
        {
            return (card1.suit == card2.suit) && (card1.rank == card2.rank);
        }

        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }

        public override bool Equals(object card)
        {
            return this == (Card) card;
        }

        public override int GetHashCode()
        {
            return 13 * (int) rank + (int) suit;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public static bool operator >(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                    return (card1.rank > card2.rank) ^ (card2.rank == Rank.Ace);
                else
                    return (card1.rank > card2.rank);
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator <(Card card1, Card card2)
        {
            return !(card1 >= card2);
        }

        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                    return (card1.rank >= card2.rank) ^ (card2.rank == Rank.Ace);
                else
                    return (card1.rank >= card2.rank);
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                {
                    return true;
                }
            }
        }

        public static bool operator <=(Card card1, Card card2)
        {
            return !(card1 > card2);
        }
    }
 }