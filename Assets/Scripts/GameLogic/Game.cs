using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Game
{
    HDeck deck;

    public Player player1;
    public Player player2;

    bool isPlayerOneActive = true;

    public Game()
    {
        deck = new HDeck();
        player1 = new Player(1);
        player2 = new Player(2);
    }

    public Player GetActivePlayer()
    {
        return (isPlayerOneActive ? player1 : player2);
    }

    public Player GetPlayerFromIndex(int index)
    {
        return (index == 1 ? player1 : player2);
    }

    public void PrintCurrentDeck()
    {
        deck.PrintDeck();
    }

    public void PrintPlayerHand(int index)
    {
        Debug.Log($"Player {index} : ");
        GetPlayerFromIndex(index).PrintCards();
    }
}
