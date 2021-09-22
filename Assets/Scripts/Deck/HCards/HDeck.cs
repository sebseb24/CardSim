using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.XR;

class HDeck : Deck<IHCard>, IDecks<IHCard>
{
    // public List<IHCard> Deck { get; set; }

    public HDeck()
    {
        deck = new List<IHCard>();

        deck.Add(new Healer());
        deck.Add(new Healer());
        deck.Add(new Healer());
        deck.Add(new Warrior());
        deck.Add(new Warrior());
        deck.Add(new Warrior());

        ShuffleDeck();
    }

    public void PrintDeck()
    {
        foreach (IHCard card in deck)
        {
            Debug.Log($"{card.Name}");
        }
    }
}
