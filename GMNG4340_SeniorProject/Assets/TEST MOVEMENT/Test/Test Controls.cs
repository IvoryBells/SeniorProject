//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/TEST MOVEMENT/Test/Test Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @TestControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @TestControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Test Controls"",
    ""maps"": [
        {
            ""name"": ""Racing"",
            ""id"": ""17636fc5-010d-414c-9251-36cfa353a307"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""b2627362-82e9-4b75-a0b4-0890178f94e8"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Drift"",
                    ""type"": ""Button"",
                    ""id"": ""da84b5aa-13b5-4134-b6b8-1c1de931a73c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Go"",
                    ""type"": ""Button"",
                    ""id"": ""4864ccca-c344-4e3f-869f-459281c32441"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0ca3cc78-9c98-4749-a623-8e048347b404"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06115f59-15eb-4ade-bdf4-787fb00b7170"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c0b4ff3-f7a9-4f6b-8812-db361e109653"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Go"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Racing
        m_Racing = asset.FindActionMap("Racing", throwIfNotFound: true);
        m_Racing_Move = m_Racing.FindAction("Move", throwIfNotFound: true);
        m_Racing_Drift = m_Racing.FindAction("Drift", throwIfNotFound: true);
        m_Racing_Go = m_Racing.FindAction("Go", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Racing
    private readonly InputActionMap m_Racing;
    private IRacingActions m_RacingActionsCallbackInterface;
    private readonly InputAction m_Racing_Move;
    private readonly InputAction m_Racing_Drift;
    private readonly InputAction m_Racing_Go;
    public struct RacingActions
    {
        private @TestControls m_Wrapper;
        public RacingActions(@TestControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Racing_Move;
        public InputAction @Drift => m_Wrapper.m_Racing_Drift;
        public InputAction @Go => m_Wrapper.m_Racing_Go;
        public InputActionMap Get() { return m_Wrapper.m_Racing; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RacingActions set) { return set.Get(); }
        public void SetCallbacks(IRacingActions instance)
        {
            if (m_Wrapper.m_RacingActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_RacingActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_RacingActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_RacingActionsCallbackInterface.OnMove;
                @Drift.started -= m_Wrapper.m_RacingActionsCallbackInterface.OnDrift;
                @Drift.performed -= m_Wrapper.m_RacingActionsCallbackInterface.OnDrift;
                @Drift.canceled -= m_Wrapper.m_RacingActionsCallbackInterface.OnDrift;
                @Go.started -= m_Wrapper.m_RacingActionsCallbackInterface.OnGo;
                @Go.performed -= m_Wrapper.m_RacingActionsCallbackInterface.OnGo;
                @Go.canceled -= m_Wrapper.m_RacingActionsCallbackInterface.OnGo;
            }
            m_Wrapper.m_RacingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Drift.started += instance.OnDrift;
                @Drift.performed += instance.OnDrift;
                @Drift.canceled += instance.OnDrift;
                @Go.started += instance.OnGo;
                @Go.performed += instance.OnGo;
                @Go.canceled += instance.OnGo;
            }
        }
    }
    public RacingActions @Racing => new RacingActions(this);
    public interface IRacingActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnDrift(InputAction.CallbackContext context);
        void OnGo(InputAction.CallbackContext context);
    }
}