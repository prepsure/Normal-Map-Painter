using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MickolPaige
{
    public static class UVUtils
    {
        public static float XYZToUVScale(Triangle tri2d, Triangle tri3d)
        {
            return tri2d.area / tri3d.area;
        }

        public static void DrawCircle(Texture2D normalMap, Vector2 center, float radius, Color fill)
        {
            for (int x = (int)(center.x - radius); x <= center.x + radius; x++)
            {
                for (int y = (int)(center.y - radius); y <= center.y + radius; y++)
                {
                    if ((new Vector2(x, y) - center).magnitude <= radius)
                    {
                        normalMap.SetPixel(x, y, fill);
                    }
                }
            }

            normalMap.Apply();
        }
    }
}
