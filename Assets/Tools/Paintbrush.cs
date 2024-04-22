using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.InputSystem.InputAction;

namespace MickolPaige
{
    

    public class Paintbrush : MonoBehaviour
    {
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
                Paint(c.ReadValue<Vector2>(), 1 << _paintingLayer);
            };

            input.Enable();
        }

        void Paint(Vector2 screenPoint, int layerMask)
        {
            bool didHit = Physics.Raycast(Camera.main.ScreenPointToRay(screenPoint), out RaycastHit hit, 999, _paintingLayer);

            if (!didHit)
            {
                return;
            }

            UVUtils.DrawCircle(painting.NormalMap, hit.textureCoord, 10, NormalMapColorUtils.VectorAsColor(new Vector3(0, 0, 1)));
        }
    }
}
