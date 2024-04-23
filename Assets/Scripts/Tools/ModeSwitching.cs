using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.InputSystem.InputAction;

namespace MickolPaige
{
    public enum Mode
    {
        Light, PaintBrush
    }

    // Switches between painting and lighting modes on spacebar press
    public class ModeSwitching : MonoBehaviour
    {
        static int index = 0;
        static Mode[] modes = { Mode.PaintBrush, Mode.Light };

        public static Mode CurrentMode {
            get {
                return modes[index];
            } 
        }

        [SerializeField]
        Image Icon;

        void Awake()
        {
            UserInput input = new();

            input.Global.ToggleMode.performed += (CallbackContext c) =>
            {
                index = (index + 1) % modes.Length;
                SetIcon();
            };

            input.Enable();

            SetIcon();
        }

        void SetIcon()
        {
            Icon.sprite = CurrentMode switch
            {
                Mode.Light => Resources.Load<Sprite>("Textures/LightIcon"),
                Mode.PaintBrush => Resources.Load<Sprite>("Textures/BrushIcon"),
                _ => null,
            };
        }
    }
}
