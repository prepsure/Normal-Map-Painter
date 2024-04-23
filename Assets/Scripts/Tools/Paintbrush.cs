using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.InputSystem.InputAction;

namespace MickolPaige
{
    // The paintbrush tool
    // Lets the user draw on an object with their mouse

    public class Paintbrush : MonoBehaviour
    {
        [SerializeField]
        Renderer MeshToPaint; // the mesh to draw on
        int _paintingLayer; // the layer to paint on, gets set to the MeshToPaint's layer

        [SerializeField]
        Image drawToImage; // The UI image to replicate the NormalMap to
        Painting painting; // The painting to draw on for the UV map

        float BrushSize = 80; // the current size of the brush (controllable with the scroll wheel)
        Func<Vector2, float, Vector2, Vector3, bool> BrushShape = BrushShapes.Circle; // the shape of the brush
        Func<Vector2, float, Vector2, Vector3, Vector3, Vector3> BrushBehavior = BrushBehaviors.Bump; // how the brush draws vectors

        // ui indicators to enable/disable
        [SerializeField]
        GameObject CircleShapeIndicator;
        [SerializeField]
        GameObject SquareShapeIndicator;
        [SerializeField]
        GameObject BumpBehaviorIndicator;
        [SerializeField]
        GameObject FlatBehaviorIndicator;

        private void Awake()
        {
            _paintingLayer = MeshToPaint.gameObject.layer;
            painting = new Painting(new Vector2(512, 512), MeshToPaint, drawToImage);

            UserInput input = new();

            input.Paintbrush.Paint.performed += (CallbackContext c) =>
            {
                if (ModeSwitching.CurrentMode != Mode.PaintBrush)
                {
                    return;
                }

                Paint(c.ReadValue<Vector2>(), 1 << _paintingLayer);
            };

            // change shape/behavior and update ui
            
            input.Paintbrush.SwitchToCircle.performed += (CallbackContext c) =>
            {
                CircleShapeIndicator.SetActive(true);
                SquareShapeIndicator.SetActive(false);
                BrushShape = BrushShapes.Circle;
            };

            input.Paintbrush.SwitchToSquare.performed += (CallbackContext c) =>
            {
                CircleShapeIndicator.SetActive(false);
                SquareShapeIndicator.SetActive(true);
                BrushShape = BrushShapes.Square;
            };

            input.Paintbrush.SwitchToBump.performed += (CallbackContext c) =>
            {
                BumpBehaviorIndicator.SetActive(true);
                FlatBehaviorIndicator.SetActive(false);
                BrushBehavior = BrushBehaviors.Bump;
            };

            input.Paintbrush.SwitchToFlat.performed += (CallbackContext c) =>
            {
                BumpBehaviorIndicator.SetActive(false);
                FlatBehaviorIndicator.SetActive(true);
                BrushBehavior = BrushBehaviors.ResetToFaceNormal;
            };

            input.Enable();
        }


        // paints onto the mesh from a screenpoint
        void Paint(Vector2 screenPoint, int layerMask)
        {
            bool didHit = Physics.Raycast(Camera.main.ScreenPointToRay(screenPoint), out RaycastHit hit, 999, layerMask);

            if (!didHit)
            {
                return;
            }

            Vector2 texelHit = Vector2.Scale(UVUtils.NormalizeCoordinates(hit.textureCoord), painting.Size);

            painting.ForEachTexel((x, y) =>
            {
                if (BrushShape(new Vector2(x, y), BrushSize, texelHit, hit.point))
                {
                    return BrushBehavior(new Vector2(x, y), BrushSize, texelHit, hit.point, hit.normal);
                }

                return null;
            });
        }
    }
}
