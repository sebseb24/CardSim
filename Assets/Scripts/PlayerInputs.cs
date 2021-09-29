// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""fb2dc1e2-58f9-410a-9382-7d301128f324"",
            ""actions"": [
                {
                    ""name"": ""ToggleCLI"",
                    ""type"": ""Button"",
                    ""id"": ""ec616cd2-3a05-4dc7-b06d-475126554802"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Return"",
                    ""type"": ""Button"",
                    ""id"": ""de9f4d7e-9cae-44fb-9ed6-2ef763824ac4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d0cb7ccc-f22b-400c-b5f8-a55a490c3752"",
                    ""path"": ""<Keyboard>/#(8)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleCLI"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e89117d-9dc1-4e55-bfce-5a0aa98c4bf4"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Return"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""CLIActions"",
            ""bindingGroup"": ""CLIActions"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_ToggleCLI = m_Player.FindAction("ToggleCLI", throwIfNotFound: true);
        m_Player_Return = m_Player.FindAction("Return", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_ToggleCLI;
    private readonly InputAction m_Player_Return;
    public struct PlayerActions
    {
        private @PlayerInputs m_Wrapper;
        public PlayerActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @ToggleCLI => m_Wrapper.m_Player_ToggleCLI;
        public InputAction @Return => m_Wrapper.m_Player_Return;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @ToggleCLI.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleCLI;
                @ToggleCLI.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleCLI;
                @ToggleCLI.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleCLI;
                @Return.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReturn;
                @Return.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReturn;
                @Return.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReturn;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ToggleCLI.started += instance.OnToggleCLI;
                @ToggleCLI.performed += instance.OnToggleCLI;
                @ToggleCLI.canceled += instance.OnToggleCLI;
                @Return.started += instance.OnReturn;
                @Return.performed += instance.OnReturn;
                @Return.canceled += instance.OnReturn;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_CLIActionsSchemeIndex = -1;
    public InputControlScheme CLIActionsScheme
    {
        get
        {
            if (m_CLIActionsSchemeIndex == -1) m_CLIActionsSchemeIndex = asset.FindControlSchemeIndex("CLIActions");
            return asset.controlSchemes[m_CLIActionsSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnToggleCLI(InputAction.CallbackContext context);
        void OnReturn(InputAction.CallbackContext context);
    }
}
