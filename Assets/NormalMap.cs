using UnityEngine;

namespace MickolPaige.Lab3
{
    public class NormalMap
    {
        public Color VectorAsColor(Vector3 v)
        {
            Vector3 n = Vector3.Normalize(v) * 2 - Vector3.one;
            return new Color(n.x, n.y, n.z);
        }

        public Color VectorAsColorOnPlane(Vector3 worldVector, Vector3 planeNormal)
        {
            // TODO transform v to be relative to the plane
            Vector3 r = worldVector;

            return VectorAsColor(r);
        }
    }
}