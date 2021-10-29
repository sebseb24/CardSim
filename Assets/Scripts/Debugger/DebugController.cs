using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DebugController : MonoBehaviour
{
    private static DebugController _instance;
    public static DebugController Instance { get { return _instance; } }

    bool showConsole;
    bool showHelp;

    string input;

    public List<object> commandList;

    private List<string> cmdHistory = new List<string>() { "" };
    private int historyIndex = 0;

    Vector2 scroll;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }

        commandList = DebugCommandList.InitializeCommandList();
    }

    private void OnGUI()
    {
        if (!showConsole) { return; }

        float y = 0f;

        if (showHelp)
        {
            GUI.Box(new Rect(0, y, Screen.width, 100), "");

            Rect viewport = new Rect(0, 0, Screen.width - 30, 20 * commandList.Count);

            scroll = GUI.BeginScrollView(new Rect(0, y + 5f, Screen.width, 90), scroll, viewport);

            for (int i = 0; i < commandList.Count; i++)
            {
                DebugCommandBase command = commandList[i] as DebugCommandBase;
                
                string label = $"{command.commandFormat} - {command.commandDescription}";

                Rect labelRect = new Rect(5, 20 * i, viewport.width - 100, 20);

                GUI.Label(labelRect, label);
            }

            GUI.EndScrollView();

            y += 100;
        }
        
        GUI.Box(new Rect(0, y, Screen.width, 30), "");
        GUI.backgroundColor = new Color(0, 0, 0, 0);
        input = GUI.TextField(new Rect(10f, y + 5f, Screen.width - 20f, 20f), input);
    }

    private void HandleInput()
    {
        if (!string.IsNullOrWhiteSpace(input))
        {
            string[] properties = input.Split(' ');
            bool noCmdFound = true;

            for (int i = 0; i < commandList.Count; i++)
            {
                DebugCommandBase commandBase = commandList[i] as DebugCommandBase;

                if (input.Contains(commandBase.commandId))
                {
                    if (commandList[i] as DebugCommand != null)
                    {
                        (commandList[i] as DebugCommand).Invoke();

                        noCmdFound = false;
                    }
                    else if (commandList[i] as DebugCommand<int> != null)
                    {
                        if (properties.Length == 2)
                            (commandList[i] as DebugCommand<int>).Invoke(int.Parse(properties[1]));
                        else
                            Debug.Log("error : Invalid command, missing an int argument");

                        noCmdFound = false;
                    }
                    cmdHistory.Add(input);
                }
            }

            if (noCmdFound)
            {
                Debug.Log("error : Invalid command, command not recognized");
            }
        }
    }

    public void ToggleHelp()
    {
        showHelp = !showHelp;
    }

    public void ToggleCLI()
    {
        showConsole = !showConsole;
        showHelp = false;
    }

    public void EnterCommand()
    {
        if (showConsole)
        {
            HandleInput();
            historyIndex = 0;
            input = cmdHistory[historyIndex];
        }
    }

    public void HistoryUp()
    {
        if (showConsole)
        {
            if (historyIndex < cmdHistory.Count-1)
            {
                input = cmdHistory[++historyIndex];
            }
        }
    }

    public void HistoryDown()
    {
        if (showConsole)
        {
            if (historyIndex > 0)
            {
                input = cmdHistory[--historyIndex];
            }
        }
    }

    public void ClearCommandHistory()
    {
        cmdHistory.Clear();
        historyIndex = 0;
        input = "";
    }
}
