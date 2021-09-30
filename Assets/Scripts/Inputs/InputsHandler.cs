using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputsHandler : MonoBehaviour
{
    // private static readonly DebugController debugger;

    private PlayerInput playerInput;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        playerInput.onActionTriggered += PlayerInput_onActionTriggered;
    }

    private void PlayerInput_onActionTriggered(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            // Debug.Log(context.control.name);
            switch (context.control.name)
            {
                case "enter":
                    DebugController.Instance.EnterCommand();
                    break;

                case "escape":
                    DebugController.Instance.ToggleCLI();
                    break;

                case "upArrow":
                    DebugController.Instance.HistoryUp();
                    break;

                case "downArrow":
                    DebugController.Instance.HistoryDown();
                    break;
            }
        }
    }
}
