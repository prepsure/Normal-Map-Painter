using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MickolPaige
{
    // Represents a UV map that will replicate to other places.
    public class Painting
    {
        public readonly Texture2D NormalMap; // the normal map we're editing
        readonly Renderer DrawToMesh; // the mesh to texture
        readonly Image DrawToImage; // the image to reflect the uv to

        public readonly Vector2 Size; // the pixel size of the normal map

        public Painting(Vector2 size, Renderer drawToMesh, Image drawToImage)
        {
            NormalMap = new Texture2D((int)size.x, (int)size.y);
            ForEachTexel((int x, int y) =>
            {
                return Vector3.forward;
            });

            DrawToMesh = drawToMesh;
            DrawToImage = drawToImage;
            Size = size;

            UpdateMaterial();
        }

        // does an operation on each texel in the uv map
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

        // updates the applied object's material to reflect the uv map
        void UpdateMaterial()
        {
            Material mat = DrawToMesh.material;
            mat.EnableKeyword("_NORMALMAP");
            mat.SetTexture("_BumpMap", NormalMap);

            DrawToImage.sprite = Sprite.Create(NormalMap, new Rect(0, 0, NormalMap.width, NormalMap.height), Vector2.zero);
        }
    }
}
