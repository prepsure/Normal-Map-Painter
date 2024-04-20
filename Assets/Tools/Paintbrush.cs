using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

namespace MickolPaige
{
    

    public class Paintbrush : MonoBehaviour
    {
        int _paintingLayer;

        private void Awake()
        {
            _paintingLayer = LayerMask.NameToLayer("Paintable");

            UserInput input = new();

            // TODO unbind this
            input.Paintbrush.Paint.performed += (CallbackContext c) =>
            {
                Paint(c.ReadValue<Vector2>(), 1 << _paintingLayer);
            };

            input.Enable();
        }

        void Paint(Vector2 screenPoint, int layerMask)
        {
            Physics.Raycast(Camera.main.ScreenPointToRay(screenPoint), out RaycastHit hit, 999, _paintingLayer);
        }
    }
}
