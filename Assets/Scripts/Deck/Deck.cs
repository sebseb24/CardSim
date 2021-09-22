using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck<T>
{
    public List<T> deck { get; set; }

    public void ShuffleDeck()
    {
        deck = deck.OrderBy( x => Random.value ).ToList();
    }

    public T DrawFirstCard()
    {
        return deck.ElementAt(0);
    }
}
