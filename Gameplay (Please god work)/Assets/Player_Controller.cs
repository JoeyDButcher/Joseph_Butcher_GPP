// GENERATED AUTOMATICALLY FROM 'Assets/Player_Controller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player_Controller : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player_Controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player_Controller"",
    ""maps"": [
        {
            ""name"": ""Controller_Input"",
            ""id"": ""ee9b76d5-f032-44e4-ae52-aa92d49a6ab4"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bba96596-a16f-4698-93d1-cd3515e7877a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""58b0f70b-4541-49a1-aa90-59e39aac1f4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""2af4c306-c59f-4414-a2d9-8172eac82c95"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dodge"",
                    ""type"": ""Button"",
                    ""id"": ""e0530473-4085-4e1b-ba75-a405879e3bb6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""81dadb62-b58d-4a7a-b044-03d7ed699b31"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a977827-2292-4d80-a873-bcb20587f88e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1167f050-b2ca-49b8-8745-ead2b026ec1d"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b47e3f08-b605-449c-894f-19ef13f7d96f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Controller_Input
        m_Controller_Input = asset.FindActionMap("Controller_Input", throwIfNotFound: true);
        m_Controller_Input_Movement = m_Controller_Input.FindAction("Movement", throwIfNotFound: true);
        m_Controller_Input_Jump = m_Controller_Input.FindAction("Jump", throwIfNotFound: true);
        m_Controller_Input_Attack = m_Controller_Input.FindAction("Attack", throwIfNotFound: true);
        m_Controller_Input_Dodge = m_Controller_Input.FindAction("Dodge", throwIfNotFound: true);
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

    // Controller_Input
    private readonly InputActionMap m_Controller_Input;
    private IController_InputActions m_Controller_InputActionsCallbackInterface;
    private readonly InputAction m_Controller_Input_Movement;
    private readonly InputAction m_Controller_Input_Jump;
    private readonly InputAction m_Controller_Input_Attack;
    private readonly InputAction m_Controller_Input_Dodge;
    public struct Controller_InputActions
    {
        private @Player_Controller m_Wrapper;
        public Controller_InputActions(@Player_Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Controller_Input_Movement;
        public InputAction @Jump => m_Wrapper.m_Controller_Input_Jump;
        public InputAction @Attack => m_Wrapper.m_Controller_Input_Attack;
        public InputAction @Dodge => m_Wrapper.m_Controller_Input_Dodge;
        public InputActionMap Get() { return m_Wrapper.m_Controller_Input; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Controller_InputActions set) { return set.Get(); }
        public void SetCallbacks(IController_InputActions instance)
        {
            if (m_Wrapper.m_Controller_InputActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Controller_InputActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Controller_InputActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Controller_InputActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_Controller_InputActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Controller_InputActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Controller_InputActionsCallbackInterface.OnJump;
                @Attack.started -= m_Wrapper.m_Controller_InputActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_Controller_InputActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_Controller_InputActionsCallbackInterface.OnAttack;
                @Dodge.started -= m_Wrapper.m_Controller_InputActionsCallbackInterface.OnDodge;
                @Dodge.performed -= m_Wrapper.m_Controller_InputActionsCallbackInterface.OnDodge;
                @Dodge.canceled -= m_Wrapper.m_Controller_InputActionsCallbackInterface.OnDodge;
            }
            m_Wrapper.m_Controller_InputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Dodge.started += instance.OnDodge;
                @Dodge.performed += instance.OnDodge;
                @Dodge.canceled += instance.OnDodge;
            }
        }
    }
    public Controller_InputActions @Controller_Input => new Controller_InputActions(this);
    public interface IController_InputActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnDodge(InputAction.CallbackContext context);
    }
}
