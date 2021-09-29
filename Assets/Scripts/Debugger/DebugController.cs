using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DebugController : MonoBehaviour
{
    bool showConsole;
    string input;

    public static DebugCommand HELLO_WORLD;

    public List<object> commandList;

    public void OnToggleCLI(InputValue value)
    {
        Debug.Log("In Toggle");
        showConsole = !showConsole;
    }

    public void OnReturn(InputValue value)
    {
        Debug.Log("In Return");
        if (showConsole)
        {
            HandleInput();
            input = "";
        }        
    }

    private void Awake()
    {
        HELLO_WORLD = new DebugCommand("hello_world", "Print a hello world to test the CLI", "hello_world", () =>
        {
            Debug.Log("Hello World, CLI is working !");
        });

        commandList = new List<object>
        {
            HELLO_WORLD
        };
    }

    private void OnGUI()
    {
        if (!showConsole) { return; }

        float y = 0f;
        GUI.Box(new Rect(0, y, Screen.width, 30), "");
        GUI.backgroundColor = new Color(0, 0, 0, 0);
        input = GUI.TextField(new Rect(10f, y + 5f, Screen.width - 20f, 20f), input);
    }

    private void HandleInput()
    {
        for (int i = 0; i < commandList.Count; i++)
        {
            DebugCommandBase commandBase = commandList[i] as DebugCommandBase;

            if (input.Contains(commandBase.commandId))
            {
                if (commandList[i] as DebugCommand != null)
                {
                    // Cast to this type and invoke the command
                    (commandList[i] as DebugCommand).Invoke();
                }
            }
        }
    }
}
