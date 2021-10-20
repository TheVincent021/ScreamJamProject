// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputActions/PlayerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""68a7dbf3-d742-4695-a2dc-6e5e710244e5"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""02f9109a-d255-49f4-bdaa-c01357ee98c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""f73a0062-8cd9-4ecb-a1ea-275a877fa3c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""01cb6103-9770-4d6e-b2ae-5e1efae40520"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6aa5b471-8208-45c3-95e2-9fc790f7df96"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""665ed699-626b-44bb-90f2-0bc498f57efd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""32484bd6-cc8e-4009-b061-725898a22e76"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b42a999a-11ae-46a6-b4e7-c06e3aef5292"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""720aa87d-05f2-4f6e-a261-2981a9219ede"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1885bd1a-c2fd-473d-ac29-fc99ed371781"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b685b9c1-8a3b-4fe0-ae3e-265dab5d33e6"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c63b9b30-1e32-4bd6-ab8c-8bb104041c8b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""befeba10-6b4d-4546-9d1b-b0fa90ef5f5e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7bdf0cd5-405c-4c59-8233-8adbb06171e5"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UIPanel"",
            ""id"": ""f9fab121-070f-4bd6-8f42-5bbc90d576b3"",
            ""actions"": [
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""519cef52-ee3d-4e81-b51e-542ea41974a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""cf3e52f2-4a04-4846-bb41-f228652ce57b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CancelSelect"",
                    ""type"": ""Button"",
                    ""id"": ""783fd605-0e2b-4b42-ae0f-16e9b6a86e96"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""23c05cd5-659f-4f25-8300-aca6175ca71e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9309d2b1-34e7-449e-993f-1a9d62e33fe0"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa65eeb0-76d7-4ed9-9f21-d712a658e9f8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7deeff1c-bc75-41c2-9279-1fb10abe4dca"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87704e16-b5f8-40e5-98d5-b256951434fd"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""CancelSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c31f6f2-3d69-48a2-bea5-528d3e778a4e"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""CancelSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a754903-c554-4a06-a4b6-bfeaf9e65ebb"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""CancelSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ce08565-276d-4e84-8f14-4177faac20a4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""CancelSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
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
        }
    ]
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_Movement = m_Default.FindAction("Movement", throwIfNotFound: true);
        m_Default_Interaction = m_Default.FindAction("Interaction", throwIfNotFound: true);
        // UIPanel
        m_UIPanel = asset.FindActionMap("UIPanel", throwIfNotFound: true);
        m_UIPanel_Cancel = m_UIPanel.FindAction("Cancel", throwIfNotFound: true);
        m_UIPanel_Select = m_UIPanel.FindAction("Select", throwIfNotFound: true);
        m_UIPanel_CancelSelect = m_UIPanel.FindAction("CancelSelect", throwIfNotFound: true);
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

    // Default
    private readonly InputActionMap m_Default;
    private IDefaultActions m_DefaultActionsCallbackInterface;
    private readonly InputAction m_Default_Movement;
    private readonly InputAction m_Default_Interaction;
    public struct DefaultActions
    {
        private @PlayerActions m_Wrapper;
        public DefaultActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Default_Movement;
        public InputAction @Interaction => m_Wrapper.m_Default_Interaction;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMovement;
                @Interaction.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnInteraction;
            }
            m_Wrapper.m_DefaultActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
            }
        }
    }
    public DefaultActions @Default => new DefaultActions(this);

    // UIPanel
    private readonly InputActionMap m_UIPanel;
    private IUIPanelActions m_UIPanelActionsCallbackInterface;
    private readonly InputAction m_UIPanel_Cancel;
    private readonly InputAction m_UIPanel_Select;
    private readonly InputAction m_UIPanel_CancelSelect;
    public struct UIPanelActions
    {
        private @PlayerActions m_Wrapper;
        public UIPanelActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Cancel => m_Wrapper.m_UIPanel_Cancel;
        public InputAction @Select => m_Wrapper.m_UIPanel_Select;
        public InputAction @CancelSelect => m_Wrapper.m_UIPanel_CancelSelect;
        public InputActionMap Get() { return m_Wrapper.m_UIPanel; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIPanelActions set) { return set.Get(); }
        public void SetCallbacks(IUIPanelActions instance)
        {
            if (m_Wrapper.m_UIPanelActionsCallbackInterface != null)
            {
                @Cancel.started -= m_Wrapper.m_UIPanelActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UIPanelActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UIPanelActionsCallbackInterface.OnCancel;
                @Select.started -= m_Wrapper.m_UIPanelActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_UIPanelActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_UIPanelActionsCallbackInterface.OnSelect;
                @CancelSelect.started -= m_Wrapper.m_UIPanelActionsCallbackInterface.OnCancelSelect;
                @CancelSelect.performed -= m_Wrapper.m_UIPanelActionsCallbackInterface.OnCancelSelect;
                @CancelSelect.canceled -= m_Wrapper.m_UIPanelActionsCallbackInterface.OnCancelSelect;
            }
            m_Wrapper.m_UIPanelActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @CancelSelect.started += instance.OnCancelSelect;
                @CancelSelect.performed += instance.OnCancelSelect;
                @CancelSelect.canceled += instance.OnCancelSelect;
            }
        }
    }
    public UIPanelActions @UIPanel => new UIPanelActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IDefaultActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
    }
    public interface IUIPanelActions
    {
        void OnCancel(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnCancelSelect(InputAction.CallbackContext context);
    }
}
