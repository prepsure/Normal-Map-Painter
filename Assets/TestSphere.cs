using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MickolPaige
{
    public class TestSphere : MonoBehaviour
    {
        Texture2D NormalMap;
        const int TEXTURE_SIZE = 128;
        const float CIRCLE_DIAMETER_SCALE = 0.9f;
        const int CIRCLE_RADIUS = (int)((TEXTURE_SIZE / 2) * 0.9f);

        private void Awake()
        {
            NormalMap = new Texture2D(TEXTURE_SIZE, TEXTURE_SIZE);
            UpdateMaterial();
        }

        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(CircleMap());
        }

        bool IsInCircle(int x, int y)
        {
            return TexelCenteredAndNormalized(x,y).magnitude < CIRCLE_DIAMETER_SCALE;
        }

        Vector2 TexelCenteredAndNormalized(int x, int y)
        {
            Vector2 pixelPos = new Vector2(x, y) / (TEXTURE_SIZE);
            Vector2 shift = -new Vector2(0.5f, 0.5f);
            Vector2 centered = pixelPos + shift;

            return centered * 2;
        }

        IEnumerator CircleMap()
        {
            Color straightForward = NormalMapColorUtils.VectorAsColor(new Vector3(0, 0, 1f));

            for (int x = 0; x < TEXTURE_SIZE; x++)
            {
                for (int y = 0; y < TEXTURE_SIZE; y++)
                {
                    if (!IsInCircle(x,y))
                    {
                        NormalMap.SetPixel(x, y, straightForward);
                        NormalMap.Apply();
                        yield return new WaitForSeconds(0.001f);
                        continue;
                    }

                    Vector2 onCircle = TexelCenteredAndNormalized(x,y);
                    Vector3 vecAtPixel = new Vector3(onCircle.x, onCircle.y, 1 - onCircle.magnitude);

                    NormalMap.SetPixel(x, y, NormalMapColorUtils.VectorAsColor(vecAtPixel));

                    NormalMap.Apply();
                    yield return new WaitForSeconds(0.001f);
                }
            }
        }

        void UpdateMaterial()
        {
            Material mat = GetComponent<Renderer>().material;
            mat.EnableKeyword("_NORMALMAP");
            mat.SetTexture("_BumpMap", NormalMap);
        }
    }
}
