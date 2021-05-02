// GENERATED AUTOMATICALLY FROM 'Assets/scripts/Player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""PlayerMain"",
            ""id"": ""72242934-a79b-499d-965e-8b66842338df"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""77c20bd1-6bc4-49c6-8030-410ccb474d38"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""03bcb325-d67a-4ffa-9980-dd00a95fc3dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""1b3c06ea-2ad4-476a-a496-c7091c03a754"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""a4664c62-d666-453d-9275-c2cc794bccf7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""openn"",
                    ""type"": ""Button"",
                    ""id"": ""b7a3e38a-4cef-4266-8b8b-16c2098834e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1c501c25-61f5-488c-8ea1-adf1769dc69e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""75d29b53-fab6-49be-909d-76547afbb209"",
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
                    ""id"": ""316199f5-2dd1-4586-9c69-46c4a52d380a"",
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
                    ""id"": ""44f53fde-664d-4250-ad12-facc312871bd"",
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
                    ""id"": ""dad4b2e8-9f63-4b47-8a14-a803c2e00f0b"",
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
                    ""id"": ""679d6c78-cdb8-4891-ae4c-85b595ccc410"",
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
                    ""id"": ""97ee699c-9cc4-4d0c-8ed9-6f58b256eed9"",
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
                    ""id"": ""ffe39a1a-a0f5-4b82-b146-9412c350ab6d"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b58524a-5fa4-4794-8e0f-1e729f903852"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f7a4ed3-370d-4632-b77c-1b9b93422ee7"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""openn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Level1"",
            ""id"": ""c67a9f15-cf02-4b87-bf8c-ad4a2e8f1ac5"",
            ""actions"": [
                {
                    ""name"": ""DoorOpen"",
                    ""type"": ""Button"",
                    ""id"": ""0d34b481-0389-43f3-abdf-af5176ba1ff4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DoorBell"",
                    ""type"": ""Button"",
                    ""id"": ""7d128f83-a1dc-43cf-ad6d-8160359f564f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Salaam"",
                    ""type"": ""Button"",
                    ""id"": ""35c1e29e-d9d6-4f3b-8b19-f38d1aad35e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dua"",
                    ""type"": ""Button"",
                    ""id"": ""482db885-c1fc-4436-b158-80f01d6ceca6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""68758288-5834-4eae-9450-4c98a1b9d2bf"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DoorOpen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81f53ab1-f272-436e-9f8d-365f0146d5f9"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DoorBell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d795b308-c038-4248-a177-490cd99711a4"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Salaam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""226754fe-89d8-4eb5-9007-b17af9d643dd"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dua"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Level2"",
            ""id"": ""21e40874-a546-4a02-8cef-a34993e49139"",
            ""actions"": [
                {
                    ""name"": ""sitDrink"",
                    ""type"": ""Button"",
                    ""id"": ""56fb9f25-b461-45f0-a264-e855da9a2b6b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""standDrink"",
                    ""type"": ""Button"",
                    ""id"": ""e416a29f-00ea-4bca-92fc-75129bb28215"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""trashCan"",
                    ""type"": ""Button"",
                    ""id"": ""6511fcf6-b7d2-4df9-a084-490fb5220b35"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""throwTrash"",
                    ""type"": ""Button"",
                    ""id"": ""73d5ba71-2a1e-4f6b-824c-2547355aec51"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""removeObstacle"",
                    ""type"": ""Button"",
                    ""id"": ""9804f82c-fe0c-4664-9de8-c3b3db0eee28"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dua"",
                    ""type"": ""Button"",
                    ""id"": ""28cc0ac9-041a-4b41-ad78-607a1ae33451"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fe4d3878-d4cb-44d2-b20f-599f73e8919b"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sitDrink"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6de89657-65c4-4629-bb82-8c7a96291877"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""standDrink"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b0c0c17-65f3-423a-bdac-7571e98fc119"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""trashCan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4d5a909-a99c-4114-a938-587c6f649d1b"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""throwTrash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2f84ce2-beda-43dd-bd77-ab1d0bc18dc6"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""removeObstacle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d542938-07b9-4be4-9c6f-ffa0a81c6251"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dua"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMain
        m_PlayerMain = asset.FindActionMap("PlayerMain", throwIfNotFound: true);
        m_PlayerMain_Move = m_PlayerMain.FindAction("Move", throwIfNotFound: true);
        m_PlayerMain_Jump = m_PlayerMain.FindAction("Jump", throwIfNotFound: true);
        m_PlayerMain_Look = m_PlayerMain.FindAction("Look", throwIfNotFound: true);
        m_PlayerMain_Run = m_PlayerMain.FindAction("Run", throwIfNotFound: true);
        m_PlayerMain_openn = m_PlayerMain.FindAction("openn", throwIfNotFound: true);
        // Level1
        m_Level1 = asset.FindActionMap("Level1", throwIfNotFound: true);
        m_Level1_DoorOpen = m_Level1.FindAction("DoorOpen", throwIfNotFound: true);
        m_Level1_DoorBell = m_Level1.FindAction("DoorBell", throwIfNotFound: true);
        m_Level1_Salaam = m_Level1.FindAction("Salaam", throwIfNotFound: true);
        m_Level1_Dua = m_Level1.FindAction("Dua", throwIfNotFound: true);
        // Level2
        m_Level2 = asset.FindActionMap("Level2", throwIfNotFound: true);
        m_Level2_sitDrink = m_Level2.FindAction("sitDrink", throwIfNotFound: true);
        m_Level2_standDrink = m_Level2.FindAction("standDrink", throwIfNotFound: true);
        m_Level2_trashCan = m_Level2.FindAction("trashCan", throwIfNotFound: true);
        m_Level2_throwTrash = m_Level2.FindAction("throwTrash", throwIfNotFound: true);
        m_Level2_removeObstacle = m_Level2.FindAction("removeObstacle", throwIfNotFound: true);
        m_Level2_Dua = m_Level2.FindAction("Dua", throwIfNotFound: true);
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

    // PlayerMain
    private readonly InputActionMap m_PlayerMain;
    private IPlayerMainActions m_PlayerMainActionsCallbackInterface;
    private readonly InputAction m_PlayerMain_Move;
    private readonly InputAction m_PlayerMain_Jump;
    private readonly InputAction m_PlayerMain_Look;
    private readonly InputAction m_PlayerMain_Run;
    private readonly InputAction m_PlayerMain_openn;
    public struct PlayerMainActions
    {
        private @Player m_Wrapper;
        public PlayerMainActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerMain_Move;
        public InputAction @Jump => m_Wrapper.m_PlayerMain_Jump;
        public InputAction @Look => m_Wrapper.m_PlayerMain_Look;
        public InputAction @Run => m_Wrapper.m_PlayerMain_Run;
        public InputAction @openn => m_Wrapper.m_PlayerMain_openn;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMain; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMainActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMainActions instance)
        {
            if (m_Wrapper.m_PlayerMainActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnLook;
                @Run.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnRun;
                @openn.started -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnOpenn;
                @openn.performed -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnOpenn;
                @openn.canceled -= m_Wrapper.m_PlayerMainActionsCallbackInterface.OnOpenn;
            }
            m_Wrapper.m_PlayerMainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @openn.started += instance.OnOpenn;
                @openn.performed += instance.OnOpenn;
                @openn.canceled += instance.OnOpenn;
            }
        }
    }
    public PlayerMainActions @PlayerMain => new PlayerMainActions(this);

    // Level1
    private readonly InputActionMap m_Level1;
    private ILevel1Actions m_Level1ActionsCallbackInterface;
    private readonly InputAction m_Level1_DoorOpen;
    private readonly InputAction m_Level1_DoorBell;
    private readonly InputAction m_Level1_Salaam;
    private readonly InputAction m_Level1_Dua;
    public struct Level1Actions
    {
        private @Player m_Wrapper;
        public Level1Actions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @DoorOpen => m_Wrapper.m_Level1_DoorOpen;
        public InputAction @DoorBell => m_Wrapper.m_Level1_DoorBell;
        public InputAction @Salaam => m_Wrapper.m_Level1_Salaam;
        public InputAction @Dua => m_Wrapper.m_Level1_Dua;
        public InputActionMap Get() { return m_Wrapper.m_Level1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Level1Actions set) { return set.Get(); }
        public void SetCallbacks(ILevel1Actions instance)
        {
            if (m_Wrapper.m_Level1ActionsCallbackInterface != null)
            {
                @DoorOpen.started -= m_Wrapper.m_Level1ActionsCallbackInterface.OnDoorOpen;
                @DoorOpen.performed -= m_Wrapper.m_Level1ActionsCallbackInterface.OnDoorOpen;
                @DoorOpen.canceled -= m_Wrapper.m_Level1ActionsCallbackInterface.OnDoorOpen;
                @DoorBell.started -= m_Wrapper.m_Level1ActionsCallbackInterface.OnDoorBell;
                @DoorBell.performed -= m_Wrapper.m_Level1ActionsCallbackInterface.OnDoorBell;
                @DoorBell.canceled -= m_Wrapper.m_Level1ActionsCallbackInterface.OnDoorBell;
                @Salaam.started -= m_Wrapper.m_Level1ActionsCallbackInterface.OnSalaam;
                @Salaam.performed -= m_Wrapper.m_Level1ActionsCallbackInterface.OnSalaam;
                @Salaam.canceled -= m_Wrapper.m_Level1ActionsCallbackInterface.OnSalaam;
                @Dua.started -= m_Wrapper.m_Level1ActionsCallbackInterface.OnDua;
                @Dua.performed -= m_Wrapper.m_Level1ActionsCallbackInterface.OnDua;
                @Dua.canceled -= m_Wrapper.m_Level1ActionsCallbackInterface.OnDua;
            }
            m_Wrapper.m_Level1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DoorOpen.started += instance.OnDoorOpen;
                @DoorOpen.performed += instance.OnDoorOpen;
                @DoorOpen.canceled += instance.OnDoorOpen;
                @DoorBell.started += instance.OnDoorBell;
                @DoorBell.performed += instance.OnDoorBell;
                @DoorBell.canceled += instance.OnDoorBell;
                @Salaam.started += instance.OnSalaam;
                @Salaam.performed += instance.OnSalaam;
                @Salaam.canceled += instance.OnSalaam;
                @Dua.started += instance.OnDua;
                @Dua.performed += instance.OnDua;
                @Dua.canceled += instance.OnDua;
            }
        }
    }
    public Level1Actions @Level1 => new Level1Actions(this);

    // Level2
    private readonly InputActionMap m_Level2;
    private ILevel2Actions m_Level2ActionsCallbackInterface;
    private readonly InputAction m_Level2_sitDrink;
    private readonly InputAction m_Level2_standDrink;
    private readonly InputAction m_Level2_trashCan;
    private readonly InputAction m_Level2_throwTrash;
    private readonly InputAction m_Level2_removeObstacle;
    private readonly InputAction m_Level2_Dua;
    public struct Level2Actions
    {
        private @Player m_Wrapper;
        public Level2Actions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @sitDrink => m_Wrapper.m_Level2_sitDrink;
        public InputAction @standDrink => m_Wrapper.m_Level2_standDrink;
        public InputAction @trashCan => m_Wrapper.m_Level2_trashCan;
        public InputAction @throwTrash => m_Wrapper.m_Level2_throwTrash;
        public InputAction @removeObstacle => m_Wrapper.m_Level2_removeObstacle;
        public InputAction @Dua => m_Wrapper.m_Level2_Dua;
        public InputActionMap Get() { return m_Wrapper.m_Level2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Level2Actions set) { return set.Get(); }
        public void SetCallbacks(ILevel2Actions instance)
        {
            if (m_Wrapper.m_Level2ActionsCallbackInterface != null)
            {
                @sitDrink.started -= m_Wrapper.m_Level2ActionsCallbackInterface.OnSitDrink;
                @sitDrink.performed -= m_Wrapper.m_Level2ActionsCallbackInterface.OnSitDrink;
                @sitDrink.canceled -= m_Wrapper.m_Level2ActionsCallbackInterface.OnSitDrink;
                @standDrink.started -= m_Wrapper.m_Level2ActionsCallbackInterface.OnStandDrink;
                @standDrink.performed -= m_Wrapper.m_Level2ActionsCallbackInterface.OnStandDrink;
                @standDrink.canceled -= m_Wrapper.m_Level2ActionsCallbackInterface.OnStandDrink;
                @trashCan.started -= m_Wrapper.m_Level2ActionsCallbackInterface.OnTrashCan;
                @trashCan.performed -= m_Wrapper.m_Level2ActionsCallbackInterface.OnTrashCan;
                @trashCan.canceled -= m_Wrapper.m_Level2ActionsCallbackInterface.OnTrashCan;
                @throwTrash.started -= m_Wrapper.m_Level2ActionsCallbackInterface.OnThrowTrash;
                @throwTrash.performed -= m_Wrapper.m_Level2ActionsCallbackInterface.OnThrowTrash;
                @throwTrash.canceled -= m_Wrapper.m_Level2ActionsCallbackInterface.OnThrowTrash;
                @removeObstacle.started -= m_Wrapper.m_Level2ActionsCallbackInterface.OnRemoveObstacle;
                @removeObstacle.performed -= m_Wrapper.m_Level2ActionsCallbackInterface.OnRemoveObstacle;
                @removeObstacle.canceled -= m_Wrapper.m_Level2ActionsCallbackInterface.OnRemoveObstacle;
                @Dua.started -= m_Wrapper.m_Level2ActionsCallbackInterface.OnDua;
                @Dua.performed -= m_Wrapper.m_Level2ActionsCallbackInterface.OnDua;
                @Dua.canceled -= m_Wrapper.m_Level2ActionsCallbackInterface.OnDua;
            }
            m_Wrapper.m_Level2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @sitDrink.started += instance.OnSitDrink;
                @sitDrink.performed += instance.OnSitDrink;
                @sitDrink.canceled += instance.OnSitDrink;
                @standDrink.started += instance.OnStandDrink;
                @standDrink.performed += instance.OnStandDrink;
                @standDrink.canceled += instance.OnStandDrink;
                @trashCan.started += instance.OnTrashCan;
                @trashCan.performed += instance.OnTrashCan;
                @trashCan.canceled += instance.OnTrashCan;
                @throwTrash.started += instance.OnThrowTrash;
                @throwTrash.performed += instance.OnThrowTrash;
                @throwTrash.canceled += instance.OnThrowTrash;
                @removeObstacle.started += instance.OnRemoveObstacle;
                @removeObstacle.performed += instance.OnRemoveObstacle;
                @removeObstacle.canceled += instance.OnRemoveObstacle;
                @Dua.started += instance.OnDua;
                @Dua.performed += instance.OnDua;
                @Dua.canceled += instance.OnDua;
            }
        }
    }
    public Level2Actions @Level2 => new Level2Actions(this);
    public interface IPlayerMainActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnOpenn(InputAction.CallbackContext context);
    }
    public interface ILevel1Actions
    {
        void OnDoorOpen(InputAction.CallbackContext context);
        void OnDoorBell(InputAction.CallbackContext context);
        void OnSalaam(InputAction.CallbackContext context);
        void OnDua(InputAction.CallbackContext context);
    }
    public interface ILevel2Actions
    {
        void OnSitDrink(InputAction.CallbackContext context);
        void OnStandDrink(InputAction.CallbackContext context);
        void OnTrashCan(InputAction.CallbackContext context);
        void OnThrowTrash(InputAction.CallbackContext context);
        void OnRemoveObstacle(InputAction.CallbackContext context);
        void OnDua(InputAction.CallbackContext context);
    }
}
