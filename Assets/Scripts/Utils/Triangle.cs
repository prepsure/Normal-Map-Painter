using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MickolPaige
{
    public class Triangle
    {
        public readonly Vector3 p1;
        public readonly Vector3 p2;
        public readonly Vector3 p3;
        public readonly float area;

        public Triangle(Vector3 p1, Vector3 p2, Vector3 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.area = CalculateArea();
        }

        float LengthOfLine(Vector3 p0, Vector3 p1)
        {
            return (p0 - p1).magnitude;
        }

        float CalculateArea()
        {
            float a = LengthOfLine(p1, p2),
                b = LengthOfLine(p2, p3),
                c = LengthOfLine(p3, p1);

            float s = (a + b + c) / 2;
            return Mathf.Sqrt(s * (s - a) + s * (s - b) + s * (s - c));
        }

        public bool Contains(Vector3 point)
        {
            // TODO
            return false;
        }

    }
}
