using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

namespace MickolPaige
{
    public class LightSnapping : MonoBehaviour
    {
        public SphereCollider SnapToSphere;

        int _snappingLayer;
        float _castingDistance = 999;

        void Awake()
        {
            _snappingLayer = SnapToSphere.gameObject.layer;

            UserInput input = new();

            input.Lighting.DragLight.performed += (CallbackContext c) =>
            {
                if (ModeSwitching.CurrentMode != Mode.Light)
                {
                    return;
                }

                SnapToLayerFromScreen(c.ReadValue<Vector2>(), 1 << _snappingLayer);
            };

            input.Enable();
        }


        void SnapToLayerFromScreen(Vector2 screenPoint, int layerMask)
        {
            Physics.Raycast(Camera.main.ScreenPointToRay(screenPoint), out RaycastHit hit, _castingDistance, layerMask);
            transform.position = SnapToSphere.ClosestPoint(hit.point);
        }
    }
}
