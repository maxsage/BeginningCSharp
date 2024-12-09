using System;

namespace _11_07UpgradedCardLib
{
    public class CardOutOfRangeException : Exception
    {
        private Cards deckContents;

        public Cards DeckContents
        {
            get
            {
                return deckContents;
            }
        }

        public CardOutOfRangeException(Cards sourceDeckContents) :
            base("There are only 52 card in the deck.")
        {
            deckContents = sourceDeckContents;
        }

    }
}