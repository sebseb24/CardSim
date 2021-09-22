using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    HDeck deck;

    void Start()
    {
        deck = new HDeck();
        deck.PrintDeck();
        IHCard firstCard = deck.DrawFirstCard();

        Debug.Log($"First card is : {firstCard.Name}");
    }
}
