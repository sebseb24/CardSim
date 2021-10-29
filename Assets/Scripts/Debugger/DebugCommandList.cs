using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DebugCommandList
{
    public static DebugCommand HELLO_WORLD;
    public static DebugCommand CLEAR_HISTORY;
    public static DebugCommand HELP;
    public static DebugCommand PRINT_DECK;
    public static DebugCommand<int> DRAW_CARDS;
    public static DebugCommand<int> PRINT_PLAYER_HAND;

    public static List<object> InitializeCommandList()
    {

        CommandInitialization();

        return new List<object> {
            HELP,
            HELLO_WORLD,
            CLEAR_HISTORY,
            DRAW_CARDS,
            PRINT_DECK,
            PRINT_PLAYER_HAND
        };
    }

    private static void CommandInitialization()
    {
        HELP = new DebugCommand("help", "Shows a list of commands", "help", () =>
        {
            DebugController.Instance.ToggleHelp();
        });

        HELLO_WORLD = new DebugCommand("hello_world", "Print a hello world to test the CLI", "hello_world", () =>
        {
            Debug.Log("Hello World, CLI is working !");
        });

        CLEAR_HISTORY = new DebugCommand("clear_history", "Clear the current command history", "clear_history", () =>
        {
            DebugController.Instance.ClearCommandHistory();
        });

        DRAW_CARDS = new DebugCommand<int>("draw_cards", "Draw x cards", "draw_cards <nb of cards>", (x) =>
        {
            Debug.Log($"Player draw {x} cards !");
        });

        PRINT_DECK = new DebugCommand("print_deck", "Print the cards in the deck of the current game", "print_deck", () =>
        {
            GameManager.Instance.PrintCurrentDeck();
        });

        PRINT_PLAYER_HAND = new DebugCommand<int>("print_player_hand", "Print the cards in the hand of the chosen player", "print_player_hand <player>", (x) =>
        {
            if (x == 1 || x == 2)
                GameManager.Instance.PrintPlayerHand(x);
            else
                Debug.Log("error : Invalid player index, please choose between player 1 or 2");
        });
    }
}
