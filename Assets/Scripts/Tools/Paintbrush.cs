using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.InputSystem.InputAction;

namespace MickolPaige
{
    public class Paintbrush : MonoBehaviour
    {
        float BrushSize = 80;

        int _paintingLayer;

        Painting painting;

        [SerializeField]
        Renderer meshToPaint;

        [SerializeField]
        Image drawToImage;

        Func<Vector2, float, Vector2, Vector3, bool> BrushShape = BrushShapes.Square;
        Func<Vector2, float, Vector2, Vector3, Vector3, Vector3> BrushBehavior = BrushBehaviors.FaceCamera;

        private void Awake()
        {
            _paintingLayer = meshToPaint.gameObject.layer;
            painting = new Painting(new Vector2(512, 512), meshToPaint, drawToImage);

            UserInput input = new();

            // TODO unbind this
            input.Paintbrush.Paint.performed += (CallbackContext c) =>
            {
                if (ModeSwitching.CurrentMode != Mode.PaintBrush)
                {
                    return;
                }

                Paint(c.ReadValue<Vector2>(), 1 << _paintingLayer);
            };

            input.Enable();
        }

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
