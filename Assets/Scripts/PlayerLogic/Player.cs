using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public int index;
    List<IHCard> cards;

    public Player(int index)
    {
        this.index = index;
        cards = new List<IHCard>();
    }

    public void DrawCards(Deck<IHCard> deck, int cnt)
    {
        cards = deck.DrawCards(cnt);
    }

    public void PrintCards()
    {
        if (cards.Count == 0)
        {
            Debug.Log("Hand is empty");
        }

        foreach (IHCard card in cards)
        {
            Debug.Log($"{card.Name}");
        }
    }
}
