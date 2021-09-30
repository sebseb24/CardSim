using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck<T>
{
    public List<T> deck { get; set; }

    public List<T> discardedDeck { get; set; }

    public Deck()
    {
        deck = new List<T>();
        discardedDeck = new List<T>();
    }

    public void ShuffleDeck()
    {
        deck = deck.OrderBy( x => Random.value ).ToList();
    }

    public T DrawFirstCard()
    {
        return deck.ElementAt(0);
    }

    public List<T> DrawCards(int value)
    {
        List<T> cards = new List<T>();
        T card;

        for (int i = 0; i < value; i++)
        {
            if (deck.Count > 0)
            {
                card = deck.ElementAt(deck.Count - 1);

                discardedDeck.Add(card);
                cards.Add(card);
                deck.RemoveAt(deck.Count - 1);
            }
            else
            {
                Debug.Log("Deck is empty");
                break;
            }
        }
        return cards;
    }
}
