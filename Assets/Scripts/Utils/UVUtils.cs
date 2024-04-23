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

        public static Vector2 NormalizeCoordinates(Vector2 coords)
        {
            Vector2 positive = coords + new Vector2(999, 999);
            return new Vector2(positive.x % 1, positive.y % 1);
        }
    }
}
