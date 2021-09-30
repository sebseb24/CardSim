using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    List<IHCard> cards;

    public Player()
    {
        cards = new List<IHCard>();
    }

    public void DrawCards(Deck<IHCard> deck, int cnt)
    {
        cards = deck.DrawCards(cnt);
    }

    public void PrintCards()
    {
        foreach (IHCard card in cards)
        {
            Debug.Log($"{card.Name}");
        }
    }
}
