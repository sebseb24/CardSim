using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DebugCommandList
{
    public static DebugCommand HELLO_WORLD;
    public static DebugCommand HELP;
    public static DebugCommand<int> DRAW_CARDS;

    public static List<object> InitializeCommandList()
    {

        CommandInitialization();

        return new List<object> {
            HELP,
            HELLO_WORLD,
            DRAW_CARDS
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

        DRAW_CARDS = new DebugCommand<int>("draw_cards", "Draw x cards", "draw_cards <nb of cards>", (x) =>
        {
            Debug.Log($"Player draw {x} cards !");
        });
    }
}
