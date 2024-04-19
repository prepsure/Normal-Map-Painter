using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MickolPaige
{
    public class UVUtils : MonoBehaviour
    {
        public float LengthOfLine(Vector3 p0, Vector3 p1)
        {
            return (p0 - p1).magnitude;
        }

        public float AreaOfTriangle(Vector3 p1, Vector3 p2, Vector3 p3)
        {
            float a = LengthOfLine(p1, p2), 
                b = LengthOfLine(p2, p3), 
                c = LengthOfLine(p3, p1);

            float s = (a + b + c) / 2;
            return Mathf.Sqrt(s * (s - a) + s * (s - b) + s * (s - c));
        }

        public float XYZToUVScale(Vector3 p1_3d, Vector3 p2_3d, Vector3 p3_3d, Vector2 p1_2d, Vector2 p2_2d, Vector2 p3_2d)
        {
            float areas2d = AreaOfTriangle(p1_3d, p2_3d, p3_3d);
            float area3d = AreaOfTriangle(p1_2d, p2_2d, p3_2d);

            return areas2d / area3d;
        }
    }
}
