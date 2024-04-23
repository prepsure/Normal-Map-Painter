using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MickolPaige
{
    public class Painting
    {
        public readonly Texture2D NormalMap;
        readonly Renderer DrawToMesh;
        readonly Image DrawToImage;

        public readonly Vector2 Size;

        public Painting(Vector2 size, Renderer drawToMesh, Image drawToImage)
        {
            NormalMap = new Texture2D((int)size.x, (int)size.y);
            ForEachTexel((int x, int y) =>
            {
                return new Vector3(0, 0, 1);
            });

            DrawToMesh = drawToMesh;
            DrawToImage = drawToImage;
            Size = size;

            UpdateMaterial();
        }

        public void ForEachTexel(Func<int, int, Vector3?> a)
        {
            for (int x = 0; x < NormalMap.width; x++) {
                for (int y = 0; y < NormalMap.height; y++)
                {
                    Vector3? maybeVector = a.Invoke(x, y);

                    if (maybeVector.HasValue)
                    {
                        NormalMap.SetPixel(x, y, NormalMapColorUtils.VectorAsColor(maybeVector.Value));
                    }
                    
                }
            }

            NormalMap.Apply();
        }

        void UpdateMaterial()
        {
            Material mat = DrawToMesh.material;
            mat.EnableKeyword("_NORMALMAP");
            mat.SetTexture("_BumpMap", NormalMap);

            DrawToImage.sprite = Sprite.Create(NormalMap, new Rect(0, 0, NormalMap.width, NormalMap.height), Vector2.zero);
        }
    }
}
