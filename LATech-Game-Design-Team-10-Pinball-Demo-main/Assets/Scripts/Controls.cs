//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Controls.inputactions
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

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Testing"",
            ""id"": ""b5bd8497-692e-4a6b-83a6-a0f0c3b19881"",
            ""actions"": [
                {
                    ""name"": ""Flipper Right"",
                    ""type"": ""Button"",
                    ""id"": ""9b5759ed-db76-4698-80e2-9cbb3a9fe6ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Flipper Left"",
                    ""type"": ""Button"",
                    ""id"": ""2b85cece-9b7a-42ca-a133-51fe0ef890e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Ball Shooter"",
                    ""type"": ""Button"",
                    ""id"": ""ddc3a473-6617-4189-a101-f8c57883ddb1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""67e14c76-4401-45c2-b568-fafc79cea1fd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flipper Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d39417b9-0187-425f-8792-1bfe96ec5cae"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flipper Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""630322e1-f84e-444b-bc17-3bd7c0fdd2ff"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flipper Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c2b8eac-fe17-4418-af28-2e91ca2b1645"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flipper Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ccc7f7a-99d1-4039-b586-8873b1e1064e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flipper Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37b1edf1-2e77-4c85-a13e-7c2ffb6999d3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flipper Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36f5e76f-5492-48ca-a9a7-d66692ea96ad"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flipper Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e38b827-c3fd-4db9-a6ee-6fe35755e79c"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flipper Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d0f96a1-791e-4760-b163-bcc5fc0de4b0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ball Shooter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Testing
        m_Testing = asset.FindActionMap("Testing", throwIfNotFound: true);
        m_Testing_FlipperRight = m_Testing.FindAction("Flipper Right", throwIfNotFound: true);
        m_Testing_FlipperLeft = m_Testing.FindAction("Flipper Left", throwIfNotFound: true);
        m_Testing_BallShooter = m_Testing.FindAction("Ball Shooter", throwIfNotFound: true);
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

    // Testing
    private readonly InputActionMap m_Testing;
    private List<ITestingActions> m_TestingActionsCallbackInterfaces = new List<ITestingActions>();
    private readonly InputAction m_Testing_FlipperRight;
    private readonly InputAction m_Testing_FlipperLeft;
    private readonly InputAction m_Testing_BallShooter;
    public struct TestingActions
    {
        private @Controls m_Wrapper;
        public TestingActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @FlipperRight => m_Wrapper.m_Testing_FlipperRight;
        public InputAction @FlipperLeft => m_Wrapper.m_Testing_FlipperLeft;
        public InputAction @BallShooter => m_Wrapper.m_Testing_BallShooter;
        public InputActionMap Get() { return m_Wrapper.m_Testing; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestingActions set) { return set.Get(); }
        public void AddCallbacks(ITestingActions instance)
        {
            if (instance == null || m_Wrapper.m_TestingActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TestingActionsCallbackInterfaces.Add(instance);
            @FlipperRight.started += instance.OnFlipperRight;
            @FlipperRight.performed += instance.OnFlipperRight;
            @FlipperRight.canceled += instance.OnFlipperRight;
            @FlipperLeft.started += instance.OnFlipperLeft;
            @FlipperLeft.performed += instance.OnFlipperLeft;
            @FlipperLeft.canceled += instance.OnFlipperLeft;
            @BallShooter.started += instance.OnBallShooter;
            @BallShooter.performed += instance.OnBallShooter;
            @BallShooter.canceled += instance.OnBallShooter;
        }

        private void UnregisterCallbacks(ITestingActions instance)
        {
            @FlipperRight.started -= instance.OnFlipperRight;
            @FlipperRight.performed -= instance.OnFlipperRight;
            @FlipperRight.canceled -= instance.OnFlipperRight;
            @FlipperLeft.started -= instance.OnFlipperLeft;
            @FlipperLeft.performed -= instance.OnFlipperLeft;
            @FlipperLeft.canceled -= instance.OnFlipperLeft;
            @BallShooter.started -= instance.OnBallShooter;
            @BallShooter.performed -= instance.OnBallShooter;
            @BallShooter.canceled -= instance.OnBallShooter;
        }

        public void RemoveCallbacks(ITestingActions instance)
        {
            if (m_Wrapper.m_TestingActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITestingActions instance)
        {
            foreach (var item in m_Wrapper.m_TestingActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TestingActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TestingActions @Testing => new TestingActions(this);
    public interface ITestingActions
    {
        void OnFlipperRight(InputAction.CallbackContext context);
        void OnFlipperLeft(InputAction.CallbackContext context);
        void OnBallShooter(InputAction.CallbackContext context);
    }
}
