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

        public static Vector3 VectorRelativeToPlane(Vector3 worldVector, Vector3 planeNormal)
        {
            Vector3 worldUp = Vector3.up;

            // TODO
            return worldVector;
        }

        public static Color VectorAsColorOnPlane(Vector3 worldVector, Vector3 planeNormal)
        {
            return VectorAsColor(VectorRelativeToPlane(worldVector, planeNormal));
        }
    }
}