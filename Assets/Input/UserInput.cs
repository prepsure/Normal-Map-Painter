//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/UserInput.inputactions
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

namespace MickolPaige
{
    public partial class @UserInput: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @UserInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""UserInput"",
    ""maps"": [
        {
            ""name"": ""Global"",
            ""id"": ""798d5d87-5f1b-45b7-8303-46fcd8b9b893"",
            ""actions"": [
                {
                    ""name"": ""ToggleMode"",
                    ""type"": ""Value"",
                    ""id"": ""54dc541d-4b08-4b96-b89c-140de8a4badb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0ecc5261-8de2-4c04-9922-21a45bfafc0c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Lighting"",
            ""id"": ""2cf2a144-f3f2-4775-b85e-ce415bb5c4c2"",
            ""actions"": [
                {
                    ""name"": ""DragLight"",
                    ""type"": ""Value"",
                    ""id"": ""5961368a-45ee-4ab7-96ea-5e8cc8860027"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ClickAndDrag"",
                    ""id"": ""ae7c0ef9-78e5-42e3-93f3-aa416a9adda1"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DragLight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Modifier"",
                    ""id"": ""3543834b-7aa6-471d-bdc0-88fdf9be2b7a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DragLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Binding"",
                    ""id"": ""148d1b10-54c4-48a0-be23-e6b7b92f25b0"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DragLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Paintbrush"",
            ""id"": ""8d9ce206-1f9e-422a-840d-d3f91db888f2"",
            ""actions"": [
                {
                    ""name"": ""Paint"",
                    ""type"": ""Value"",
                    ""id"": ""5fa2571e-1c74-4a19-bef9-6bccfb2b575b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SwitchToCircle"",
                    ""type"": ""Button"",
                    ""id"": ""17bfe6d3-198d-4619-87cb-b296d980a995"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchToSquare"",
                    ""type"": ""Button"",
                    ""id"": ""235498d9-7fd4-4cca-95a0-11947fc7dac3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchToBump"",
                    ""type"": ""Button"",
                    ""id"": ""9991a3a9-a26d-4859-be78-04388c083dd7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchToFlat"",
                    ""type"": ""Button"",
                    ""id"": ""c2a7ba92-1cb2-47f3-bdd9-394858874006"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ClickAndDrag"",
                    ""id"": ""aa555a8a-5abb-46c7-a3c4-ba8a8ecbbebd"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Paint"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Modifier"",
                    ""id"": ""3d66f0bb-ca7b-4b33-8ef1-976f7c81050b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Paint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Binding"",
                    ""id"": ""60edf940-c1f6-44ae-8e02-f976ae7090a2"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Paint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""11df5ed1-0b34-4bfd-b8da-04bfa4babe07"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchToSquare"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22479383-bfcc-4287-9bac-3212528166e2"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchToCircle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1eb72c42-afcd-4be5-9569-b8feb476d14a"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchToFlat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19991ef0-98e6-4813-bc9a-0b58f442d05e"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchToBump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""a3a32a94-0c24-45dd-9349-c47183c310bf"",
            ""actions"": [
                {
                    ""name"": ""Orbit"",
                    ""type"": ""Value"",
                    ""id"": ""c48feff0-c0a5-444c-9c3d-8bf491f71ccf"",
                    ""expectedControlType"": ""Delta"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""OrbitFinished"",
                    ""type"": ""Button"",
                    ""id"": ""ca0b1181-bbbc-40f8-ae09-68d690ac46f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ClickAndDrag"",
                    ""id"": ""9e545fab-239c-46dc-9990-90d56ee66812"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Orbit"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Modifier"",
                    ""id"": ""cad28a1b-0455-4e94-a544-69b94f5d35f0"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Orbit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Binding"",
                    ""id"": ""415dac60-0f16-413d-9e42-daefdf6ae49a"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Orbit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4c680bed-5d0d-4d3b-8540-a79d7e1c6255"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OrbitFinished"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Global
            m_Global = asset.FindActionMap("Global", throwIfNotFound: true);
            m_Global_ToggleMode = m_Global.FindAction("ToggleMode", throwIfNotFound: true);
            // Lighting
            m_Lighting = asset.FindActionMap("Lighting", throwIfNotFound: true);
            m_Lighting_DragLight = m_Lighting.FindAction("DragLight", throwIfNotFound: true);
            // Paintbrush
            m_Paintbrush = asset.FindActionMap("Paintbrush", throwIfNotFound: true);
            m_Paintbrush_Paint = m_Paintbrush.FindAction("Paint", throwIfNotFound: true);
            m_Paintbrush_SwitchToCircle = m_Paintbrush.FindAction("SwitchToCircle", throwIfNotFound: true);
            m_Paintbrush_SwitchToSquare = m_Paintbrush.FindAction("SwitchToSquare", throwIfNotFound: true);
            m_Paintbrush_SwitchToBump = m_Paintbrush.FindAction("SwitchToBump", throwIfNotFound: true);
            m_Paintbrush_SwitchToFlat = m_Paintbrush.FindAction("SwitchToFlat", throwIfNotFound: true);
            // Camera
            m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
            m_Camera_Orbit = m_Camera.FindAction("Orbit", throwIfNotFound: true);
            m_Camera_OrbitFinished = m_Camera.FindAction("OrbitFinished", throwIfNotFound: true);
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

        // Global
        private readonly InputActionMap m_Global;
        private List<IGlobalActions> m_GlobalActionsCallbackInterfaces = new List<IGlobalActions>();
        private readonly InputAction m_Global_ToggleMode;
        public struct GlobalActions
        {
            private @UserInput m_Wrapper;
            public GlobalActions(@UserInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @ToggleMode => m_Wrapper.m_Global_ToggleMode;
            public InputActionMap Get() { return m_Wrapper.m_Global; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GlobalActions set) { return set.Get(); }
            public void AddCallbacks(IGlobalActions instance)
            {
                if (instance == null || m_Wrapper.m_GlobalActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_GlobalActionsCallbackInterfaces.Add(instance);
                @ToggleMode.started += instance.OnToggleMode;
                @ToggleMode.performed += instance.OnToggleMode;
                @ToggleMode.canceled += instance.OnToggleMode;
            }

            private void UnregisterCallbacks(IGlobalActions instance)
            {
                @ToggleMode.started -= instance.OnToggleMode;
                @ToggleMode.performed -= instance.OnToggleMode;
                @ToggleMode.canceled -= instance.OnToggleMode;
            }

            public void RemoveCallbacks(IGlobalActions instance)
            {
                if (m_Wrapper.m_GlobalActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IGlobalActions instance)
            {
                foreach (var item in m_Wrapper.m_GlobalActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_GlobalActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public GlobalActions @Global => new GlobalActions(this);

        // Lighting
        private readonly InputActionMap m_Lighting;
        private List<ILightingActions> m_LightingActionsCallbackInterfaces = new List<ILightingActions>();
        private readonly InputAction m_Lighting_DragLight;
        public struct LightingActions
        {
            private @UserInput m_Wrapper;
            public LightingActions(@UserInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @DragLight => m_Wrapper.m_Lighting_DragLight;
            public InputActionMap Get() { return m_Wrapper.m_Lighting; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(LightingActions set) { return set.Get(); }
            public void AddCallbacks(ILightingActions instance)
            {
                if (instance == null || m_Wrapper.m_LightingActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_LightingActionsCallbackInterfaces.Add(instance);
                @DragLight.started += instance.OnDragLight;
                @DragLight.performed += instance.OnDragLight;
                @DragLight.canceled += instance.OnDragLight;
            }

            private void UnregisterCallbacks(ILightingActions instance)
            {
                @DragLight.started -= instance.OnDragLight;
                @DragLight.performed -= instance.OnDragLight;
                @DragLight.canceled -= instance.OnDragLight;
            }

            public void RemoveCallbacks(ILightingActions instance)
            {
                if (m_Wrapper.m_LightingActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ILightingActions instance)
            {
                foreach (var item in m_Wrapper.m_LightingActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_LightingActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public LightingActions @Lighting => new LightingActions(this);

        // Paintbrush
        private readonly InputActionMap m_Paintbrush;
        private List<IPaintbrushActions> m_PaintbrushActionsCallbackInterfaces = new List<IPaintbrushActions>();
        private readonly InputAction m_Paintbrush_Paint;
        private readonly InputAction m_Paintbrush_SwitchToCircle;
        private readonly InputAction m_Paintbrush_SwitchToSquare;
        private readonly InputAction m_Paintbrush_SwitchToBump;
        private readonly InputAction m_Paintbrush_SwitchToFlat;
        public struct PaintbrushActions
        {
            private @UserInput m_Wrapper;
            public PaintbrushActions(@UserInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Paint => m_Wrapper.m_Paintbrush_Paint;
            public InputAction @SwitchToCircle => m_Wrapper.m_Paintbrush_SwitchToCircle;
            public InputAction @SwitchToSquare => m_Wrapper.m_Paintbrush_SwitchToSquare;
            public InputAction @SwitchToBump => m_Wrapper.m_Paintbrush_SwitchToBump;
            public InputAction @SwitchToFlat => m_Wrapper.m_Paintbrush_SwitchToFlat;
            public InputActionMap Get() { return m_Wrapper.m_Paintbrush; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PaintbrushActions set) { return set.Get(); }
            public void AddCallbacks(IPaintbrushActions instance)
            {
                if (instance == null || m_Wrapper.m_PaintbrushActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_PaintbrushActionsCallbackInterfaces.Add(instance);
                @Paint.started += instance.OnPaint;
                @Paint.performed += instance.OnPaint;
                @Paint.canceled += instance.OnPaint;
                @SwitchToCircle.started += instance.OnSwitchToCircle;
                @SwitchToCircle.performed += instance.OnSwitchToCircle;
                @SwitchToCircle.canceled += instance.OnSwitchToCircle;
                @SwitchToSquare.started += instance.OnSwitchToSquare;
                @SwitchToSquare.performed += instance.OnSwitchToSquare;
                @SwitchToSquare.canceled += instance.OnSwitchToSquare;
                @SwitchToBump.started += instance.OnSwitchToBump;
                @SwitchToBump.performed += instance.OnSwitchToBump;
                @SwitchToBump.canceled += instance.OnSwitchToBump;
                @SwitchToFlat.started += instance.OnSwitchToFlat;
                @SwitchToFlat.performed += instance.OnSwitchToFlat;
                @SwitchToFlat.canceled += instance.OnSwitchToFlat;
            }

            private void UnregisterCallbacks(IPaintbrushActions instance)
            {
                @Paint.started -= instance.OnPaint;
                @Paint.performed -= instance.OnPaint;
                @Paint.canceled -= instance.OnPaint;
                @SwitchToCircle.started -= instance.OnSwitchToCircle;
                @SwitchToCircle.performed -= instance.OnSwitchToCircle;
                @SwitchToCircle.canceled -= instance.OnSwitchToCircle;
                @SwitchToSquare.started -= instance.OnSwitchToSquare;
                @SwitchToSquare.performed -= instance.OnSwitchToSquare;
                @SwitchToSquare.canceled -= instance.OnSwitchToSquare;
                @SwitchToBump.started -= instance.OnSwitchToBump;
                @SwitchToBump.performed -= instance.OnSwitchToBump;
                @SwitchToBump.canceled -= instance.OnSwitchToBump;
                @SwitchToFlat.started -= instance.OnSwitchToFlat;
                @SwitchToFlat.performed -= instance.OnSwitchToFlat;
                @SwitchToFlat.canceled -= instance.OnSwitchToFlat;
            }

            public void RemoveCallbacks(IPaintbrushActions instance)
            {
                if (m_Wrapper.m_PaintbrushActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IPaintbrushActions instance)
            {
                foreach (var item in m_Wrapper.m_PaintbrushActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_PaintbrushActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public PaintbrushActions @Paintbrush => new PaintbrushActions(this);

        // Camera
        private readonly InputActionMap m_Camera;
        private List<ICameraActions> m_CameraActionsCallbackInterfaces = new List<ICameraActions>();
        private readonly InputAction m_Camera_Orbit;
        private readonly InputAction m_Camera_OrbitFinished;
        public struct CameraActions
        {
            private @UserInput m_Wrapper;
            public CameraActions(@UserInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Orbit => m_Wrapper.m_Camera_Orbit;
            public InputAction @OrbitFinished => m_Wrapper.m_Camera_OrbitFinished;
            public InputActionMap Get() { return m_Wrapper.m_Camera; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
            public void AddCallbacks(ICameraActions instance)
            {
                if (instance == null || m_Wrapper.m_CameraActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_CameraActionsCallbackInterfaces.Add(instance);
                @Orbit.started += instance.OnOrbit;
                @Orbit.performed += instance.OnOrbit;
                @Orbit.canceled += instance.OnOrbit;
                @OrbitFinished.started += instance.OnOrbitFinished;
                @OrbitFinished.performed += instance.OnOrbitFinished;
                @OrbitFinished.canceled += instance.OnOrbitFinished;
            }

            private void UnregisterCallbacks(ICameraActions instance)
            {
                @Orbit.started -= instance.OnOrbit;
                @Orbit.performed -= instance.OnOrbit;
                @Orbit.canceled -= instance.OnOrbit;
                @OrbitFinished.started -= instance.OnOrbitFinished;
                @OrbitFinished.performed -= instance.OnOrbitFinished;
                @OrbitFinished.canceled -= instance.OnOrbitFinished;
            }

            public void RemoveCallbacks(ICameraActions instance)
            {
                if (m_Wrapper.m_CameraActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ICameraActions instance)
            {
                foreach (var item in m_Wrapper.m_CameraActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_CameraActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public CameraActions @Camera => new CameraActions(this);
        public interface IGlobalActions
        {
            void OnToggleMode(InputAction.CallbackContext context);
        }
        public interface ILightingActions
        {
            void OnDragLight(InputAction.CallbackContext context);
        }
        public interface IPaintbrushActions
        {
            void OnPaint(InputAction.CallbackContext context);
            void OnSwitchToCircle(InputAction.CallbackContext context);
            void OnSwitchToSquare(InputAction.CallbackContext context);
            void OnSwitchToBump(InputAction.CallbackContext context);
            void OnSwitchToFlat(InputAction.CallbackContext context);
        }
        public interface ICameraActions
        {
            void OnOrbit(InputAction.CallbackContext context);
            void OnOrbitFinished(InputAction.CallbackContext context);
        }
    }
}
