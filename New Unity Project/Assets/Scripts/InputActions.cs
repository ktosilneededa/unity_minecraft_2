// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerControl"",
            ""id"": ""cb2b4dd3-5503-41d0-9e5f-086ecf792ef4"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""9e5ab8c1-ee4d-43cf-9868-3e126da334f2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""135f0f43-8ae9-4889-af01-d194afeac381"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""fedbcc3c-975e-4321-a1a6-ca54d0a9e02e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SetVoxel"",
                    ""type"": ""Button"",
                    ""id"": ""80f6b040-eaaf-4eb9-82a5-0285a8285f46"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RemoveVoxel"",
                    ""type"": ""Button"",
                    ""id"": ""c3299ee0-3240-4ac0-a679-7b9d1a5ee753"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""23e729e8-d173-44db-a088-73692860dc57"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0def7c34-11ba-4a47-aa34-0246f19868aa"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""42406af9-f703-4b04-af08-8502c2ebe5f5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f0f7d47c-4904-49f2-afd3-4c78d5e53a9e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""22ff94b4-1b75-41f8-a6a7-89ddc7f3d86b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""40b482bf-fa1d-49fa-98fd-a066ff6af406"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b45669c1-4e80-478b-90f4-67dd4b7bde1f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffcd439e-691a-4bba-a92b-dc8862e7aeff"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RemoveVoxel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e58c61e-e013-4fde-960e-27f646d360bc"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetVoxel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GameOver"",
            ""id"": ""257edef9-906a-49f0-bfb9-6994b40ac600"",
            ""actions"": [
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""8aa84afe-bb20-4594-a1f5-29beddf1c68d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""f7814578-925e-4839-9eea-d32f15f4393b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""21b178fe-4d4c-4d9d-a782-283dc1633254"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""045bcc8b-63c8-4f4f-9b0b-e0484ba83366"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""StartGame"",
            ""id"": ""ddc85eda-4ec4-417c-bc89-33b437a1f401"",
            ""actions"": [
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""2703058b-f69e-4d53-a91b-54a755be91b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""10c44aa7-8522-4794-a91c-bf34b2e36d88"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControl
        m_PlayerControl = asset.FindActionMap("PlayerControl", throwIfNotFound: true);
        m_PlayerControl_Move = m_PlayerControl.FindAction("Move", throwIfNotFound: true);
        m_PlayerControl_Look = m_PlayerControl.FindAction("Look", throwIfNotFound: true);
        m_PlayerControl_Jump = m_PlayerControl.FindAction("Jump", throwIfNotFound: true);
        m_PlayerControl_SetVoxel = m_PlayerControl.FindAction("SetVoxel", throwIfNotFound: true);
        m_PlayerControl_RemoveVoxel = m_PlayerControl.FindAction("RemoveVoxel", throwIfNotFound: true);
        // GameOver
        m_GameOver = asset.FindActionMap("GameOver", throwIfNotFound: true);
        m_GameOver_Exit = m_GameOver.FindAction("Exit", throwIfNotFound: true);
        m_GameOver_Restart = m_GameOver.FindAction("Restart", throwIfNotFound: true);
        // StartGame
        m_StartGame = asset.FindActionMap("StartGame", throwIfNotFound: true);
        m_StartGame_Start = m_StartGame.FindAction("Start", throwIfNotFound: true);
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

    // PlayerControl
    private readonly InputActionMap m_PlayerControl;
    private IPlayerControlActions m_PlayerControlActionsCallbackInterface;
    private readonly InputAction m_PlayerControl_Move;
    private readonly InputAction m_PlayerControl_Look;
    private readonly InputAction m_PlayerControl_Jump;
    private readonly InputAction m_PlayerControl_SetVoxel;
    private readonly InputAction m_PlayerControl_RemoveVoxel;
    public struct PlayerControlActions
    {
        private @InputActions m_Wrapper;
        public PlayerControlActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControl_Move;
        public InputAction @Look => m_Wrapper.m_PlayerControl_Look;
        public InputAction @Jump => m_Wrapper.m_PlayerControl_Jump;
        public InputAction @SetVoxel => m_Wrapper.m_PlayerControl_SetVoxel;
        public InputAction @RemoveVoxel => m_Wrapper.m_PlayerControl_RemoveVoxel;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlActions instance)
        {
            if (m_Wrapper.m_PlayerControlActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnLook;
                @Jump.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJump;
                @SetVoxel.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSetVoxel;
                @SetVoxel.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSetVoxel;
                @SetVoxel.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSetVoxel;
                @RemoveVoxel.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnRemoveVoxel;
                @RemoveVoxel.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnRemoveVoxel;
                @RemoveVoxel.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnRemoveVoxel;
            }
            m_Wrapper.m_PlayerControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @SetVoxel.started += instance.OnSetVoxel;
                @SetVoxel.performed += instance.OnSetVoxel;
                @SetVoxel.canceled += instance.OnSetVoxel;
                @RemoveVoxel.started += instance.OnRemoveVoxel;
                @RemoveVoxel.performed += instance.OnRemoveVoxel;
                @RemoveVoxel.canceled += instance.OnRemoveVoxel;
            }
        }
    }
    public PlayerControlActions @PlayerControl => new PlayerControlActions(this);

    // GameOver
    private readonly InputActionMap m_GameOver;
    private IGameOverActions m_GameOverActionsCallbackInterface;
    private readonly InputAction m_GameOver_Exit;
    private readonly InputAction m_GameOver_Restart;
    public struct GameOverActions
    {
        private @InputActions m_Wrapper;
        public GameOverActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Exit => m_Wrapper.m_GameOver_Exit;
        public InputAction @Restart => m_Wrapper.m_GameOver_Restart;
        public InputActionMap Get() { return m_Wrapper.m_GameOver; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameOverActions set) { return set.Get(); }
        public void SetCallbacks(IGameOverActions instance)
        {
            if (m_Wrapper.m_GameOverActionsCallbackInterface != null)
            {
                @Exit.started -= m_Wrapper.m_GameOverActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_GameOverActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_GameOverActionsCallbackInterface.OnExit;
                @Restart.started -= m_Wrapper.m_GameOverActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_GameOverActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_GameOverActionsCallbackInterface.OnRestart;
            }
            m_Wrapper.m_GameOverActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
            }
        }
    }
    public GameOverActions @GameOver => new GameOverActions(this);

    // StartGame
    private readonly InputActionMap m_StartGame;
    private IStartGameActions m_StartGameActionsCallbackInterface;
    private readonly InputAction m_StartGame_Start;
    public struct StartGameActions
    {
        private @InputActions m_Wrapper;
        public StartGameActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Start => m_Wrapper.m_StartGame_Start;
        public InputActionMap Get() { return m_Wrapper.m_StartGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StartGameActions set) { return set.Get(); }
        public void SetCallbacks(IStartGameActions instance)
        {
            if (m_Wrapper.m_StartGameActionsCallbackInterface != null)
            {
                @Start.started -= m_Wrapper.m_StartGameActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_StartGameActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_StartGameActionsCallbackInterface.OnStart;
            }
            m_Wrapper.m_StartGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
            }
        }
    }
    public StartGameActions @StartGame => new StartGameActions(this);
    public interface IPlayerControlActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSetVoxel(InputAction.CallbackContext context);
        void OnRemoveVoxel(InputAction.CallbackContext context);
    }
    public interface IGameOverActions
    {
        void OnExit(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
    }
    public interface IStartGameActions
    {
        void OnStart(InputAction.CallbackContext context);
    }
}
