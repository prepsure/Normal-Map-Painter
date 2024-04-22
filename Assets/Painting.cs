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
            //mat.SetTexture("_MainTex", NormalMap);
            mat.SetTexture("_BumpMap", NormalMap);

            DrawToImage.sprite = Sprite.Create(NormalMap, new Rect(0, 0, NormalMap.width, NormalMap.height), Vector2.zero);
        }

        //// Start is called before the first frame update
        //void Start()
        //{
        //    CircleMap();
        //}

        //bool IsInCircle(int x, int y)
        //{
        //    return TexelCenteredAndNormalized(x,y).magnitude < CIRCLE_DIAMETER_SCALE;
        //}

        //Vector2 TexelCenteredAndNormalized(int x, int y)
        //{
        //    Vector2 pixelPos = new Vector2(x, y) / (TEXTURE_SIZE);
        //    Vector2 shift = -new Vector2(0.5f, 0.5f);
        //    Vector2 centered = pixelPos + shift;

        //    return centered * 2;
        //}

        //void CircleMap()
        //{
        //    Color straightForward = NormalMapColorUtils.VectorAsColor(new Vector3(0, 0, 1f));

        //    for (int x = 0; x < TEXTURE_SIZE; x++)
        //    {
        //        for (int y = 0; y < TEXTURE_SIZE; y++)
        //        {
        //            if (!IsInCircle(x,y))
        //            {
        //                NormalMap.SetPixel(x, y, straightForward);
        //                continue;
        //            }

        //            Vector2 onCircle = TexelCenteredAndNormalized(x,y);
        //            Vector3 vecAtPixel = new Vector3(onCircle.x, onCircle.y, 1 - onCircle.magnitude);

        //            NormalMap.SetPixel(x, y, NormalMapColorUtils.VectorAsColor(vecAtPixel));

        //        }
        //    }

        //    NormalMap.Apply();
        //}
    }
}
