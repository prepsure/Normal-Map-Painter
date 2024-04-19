using UnityEngine;

namespace MickolPaige
{
    public static class NormalMapColorUtils
    {
        public static Color VectorAsColor(Vector3 v)
        {
            Vector3 n = (Vector3.Normalize(v) + Vector3.one) / 2;
            return new Color(n.x, n.y, n.z);
        }

        public static Color VectorAsColorOnPlane(Vector3 worldVector, Vector3 planeNormal)
        {
            // TODO transform v to be relative to the plane
            Vector3 r = worldVector;

            return VectorAsColor(r);
        }
    }
}