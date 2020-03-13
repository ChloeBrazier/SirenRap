// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Test"",
            ""id"": ""383957f4-231d-445f-84bc-5d5bf9cad049"",
            ""actions"": [
                {
                    ""name"": ""Press Up"",
                    ""type"": ""Button"",
                    ""id"": ""b05847cf-fbe4-4cf3-b49b-d0cfea339f6a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Press Down"",
                    ""type"": ""Button"",
                    ""id"": ""57a57656-c70d-48f1-af85-e94b667e1149"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Press Left"",
                    ""type"": ""Button"",
                    ""id"": ""b84b2cfc-8df8-494f-9d65-1d619ce42490"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Press Right"",
                    ""type"": ""Button"",
                    ""id"": ""2ad963e4-2e81-46b5-af8f-0dc8c0dbde38"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Speed Up"",
                    ""type"": ""Button"",
                    ""id"": ""3df6d5b7-b8c4-4d8a-8a9e-1f47850b32f6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""755a1dca-ab76-456e-baed-30d5e7e5b29e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f52bd103-3e2f-4acc-a2be-d1ea482a4c55"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Press Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40482939-bddf-4455-b0d8-309ba31d7425"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Press Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7145be3d-ccc6-416c-970d-54f1d7e7433c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Press Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87777e5c-d96a-42a6-b7f8-2c9f3ff79fe0"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Press Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""907aafec-3fb1-4d4b-9d0b-1f6465deb8f8"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Press Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce94be87-0077-4e93-b21a-b36c2574d290"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Press Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0b05676-1601-4b52-9a78-7c92c88f9edc"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Press Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b3aac36-c925-4725-a101-85a714831f00"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Press Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dca5712f-700d-410f-a819-78901c56a238"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Press Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c9ac86f-46c5-422f-b811-9646384177ed"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Press Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44cb47f4-10ce-4b91-a826-6bb8e68696fc"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Press Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac637bbf-294a-469b-9988-39fb325cd03f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Press Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c0c428a-96b3-43ba-96d4-4dcdf1c4c488"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Speed Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc6a5bf5-49c4-4ce5-98a8-da10000ce1bf"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Speed Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbc53e5e-f8c2-41b8-9de9-62c02b15aa1f"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da327a05-ac12-44c5-a92a-94dc3fc9f507"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Test
        m_Test = asset.FindActionMap("Test", throwIfNotFound: true);
        m_Test_PressUp = m_Test.FindAction("Press Up", throwIfNotFound: true);
        m_Test_PressDown = m_Test.FindAction("Press Down", throwIfNotFound: true);
        m_Test_PressLeft = m_Test.FindAction("Press Left", throwIfNotFound: true);
        m_Test_PressRight = m_Test.FindAction("Press Right", throwIfNotFound: true);
        m_Test_SpeedUp = m_Test.FindAction("Speed Up", throwIfNotFound: true);
        m_Test_Start = m_Test.FindAction("Start", throwIfNotFound: true);
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

    // Test
    private readonly InputActionMap m_Test;
    private ITestActions m_TestActionsCallbackInterface;
    private readonly InputAction m_Test_PressUp;
    private readonly InputAction m_Test_PressDown;
    private readonly InputAction m_Test_PressLeft;
    private readonly InputAction m_Test_PressRight;
    private readonly InputAction m_Test_SpeedUp;
    private readonly InputAction m_Test_Start;
    public struct TestActions
    {
        private @InputMaster m_Wrapper;
        public TestActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @PressUp => m_Wrapper.m_Test_PressUp;
        public InputAction @PressDown => m_Wrapper.m_Test_PressDown;
        public InputAction @PressLeft => m_Wrapper.m_Test_PressLeft;
        public InputAction @PressRight => m_Wrapper.m_Test_PressRight;
        public InputAction @SpeedUp => m_Wrapper.m_Test_SpeedUp;
        public InputAction @Start => m_Wrapper.m_Test_Start;
        public InputActionMap Get() { return m_Wrapper.m_Test; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestActions set) { return set.Get(); }
        public void SetCallbacks(ITestActions instance)
        {
            if (m_Wrapper.m_TestActionsCallbackInterface != null)
            {
                @PressUp.started -= m_Wrapper.m_TestActionsCallbackInterface.OnPressUp;
                @PressUp.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnPressUp;
                @PressUp.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnPressUp;
                @PressDown.started -= m_Wrapper.m_TestActionsCallbackInterface.OnPressDown;
                @PressDown.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnPressDown;
                @PressDown.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnPressDown;
                @PressLeft.started -= m_Wrapper.m_TestActionsCallbackInterface.OnPressLeft;
                @PressLeft.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnPressLeft;
                @PressLeft.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnPressLeft;
                @PressRight.started -= m_Wrapper.m_TestActionsCallbackInterface.OnPressRight;
                @PressRight.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnPressRight;
                @PressRight.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnPressRight;
                @SpeedUp.started -= m_Wrapper.m_TestActionsCallbackInterface.OnSpeedUp;
                @SpeedUp.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnSpeedUp;
                @SpeedUp.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnSpeedUp;
                @Start.started -= m_Wrapper.m_TestActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnStart;
            }
            m_Wrapper.m_TestActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PressUp.started += instance.OnPressUp;
                @PressUp.performed += instance.OnPressUp;
                @PressUp.canceled += instance.OnPressUp;
                @PressDown.started += instance.OnPressDown;
                @PressDown.performed += instance.OnPressDown;
                @PressDown.canceled += instance.OnPressDown;
                @PressLeft.started += instance.OnPressLeft;
                @PressLeft.performed += instance.OnPressLeft;
                @PressLeft.canceled += instance.OnPressLeft;
                @PressRight.started += instance.OnPressRight;
                @PressRight.performed += instance.OnPressRight;
                @PressRight.canceled += instance.OnPressRight;
                @SpeedUp.started += instance.OnSpeedUp;
                @SpeedUp.performed += instance.OnSpeedUp;
                @SpeedUp.canceled += instance.OnSpeedUp;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
            }
        }
    }
    public TestActions @Test => new TestActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface ITestActions
    {
        void OnPressUp(InputAction.CallbackContext context);
        void OnPressDown(InputAction.CallbackContext context);
        void OnPressLeft(InputAction.CallbackContext context);
        void OnPressRight(InputAction.CallbackContext context);
        void OnSpeedUp(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
    }
}
