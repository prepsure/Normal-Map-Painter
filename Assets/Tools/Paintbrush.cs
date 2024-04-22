using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.InputSystem.InputAction;

namespace MickolPaige
{
    

    public class Paintbrush : MonoBehaviour
    {
        float brushSize;

        int _paintingLayer;

        Painting painting;

        [SerializeField]
        Renderer meshToPaint;

        [SerializeField]
        Image drawToImage;

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

            Debug.Log(hit.textureCoord);
            UVUtils.DrawCircle(painting, Vector2.Scale(UVUtils.NormalizeCoordinates(hit.textureCoord), painting.Size), 100);
        }
    }
}
