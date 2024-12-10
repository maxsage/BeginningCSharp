using System;
using System.Collections;
namespace _12_04UpgradedCardLib
{
    public class Cards : CollectionBase, ICloneable
    {
        public void Add(Card newCard)
        {
            List.Add(newCard);
        }

        public void Remove(Card oldCard)
        {
            List.Remove(oldCard);
        }

        public Cards()
        {
        }

        public Card this[int cardIndex]
        {
            get { return (Card) List[cardIndex]; }
            set { List[cardIndex] = value; }
        }

        // Check to see if the Cards collection contains an particular card.
        // This calls the Contains method of the ArrayList for the collection,
        // which we access through the InnerList property.
        public bool Contains(Card card)
        {
            return InnerList.Contains(card);
        }

        public object Clone()
        {
            Cards newCards = new Cards();
            foreach (Card sourceCard in List)
            {
                newCards.Add((Card)sourceCard.Clone());
            }

            return newCards;
        }
    }
}