using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class StandardDeck : Deck<Card>, IDecks<Card>
{
    // public List<Card> Deck { get; set; }

    public StandardDeck()
    {
        deck = new List<Card>();

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                deck.Add(new Card((Values)(j + 1), (Colors)i));
            }
        }

        ShuffleDeck();
    }

    public void PrintDeck()
    {
        foreach (Card card in deck)
        {
            Debug.Log($"{card.value} of {card.color}");
        }
    }
}
