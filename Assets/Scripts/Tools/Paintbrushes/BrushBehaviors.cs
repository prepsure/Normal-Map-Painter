using UnityEngine;

namespace MickolPaige
{
    // Functions for brush behaviors.
    // Will return the vector to draw on the surface from the provided input.
    public static class BrushBehaviors
    {
        public static Vector3 FaceCamera(Vector2 currentPixel, float brushSize, Vector2 postionHit2d, Vector3 positionHit3d, Vector3 normalHit3d)
        {
            return NormalMapColorUtils.VectorRelativeToPlane(Camera.main.transform.position - positionHit3d, normalHit3d);
        }

        public static Vector3 ResetToFaceNormal(Vector2 currentPixel, float brushSize, Vector2 postionHit2d, Vector3 positionHit3d, Vector3 normalHit3d)
        {
            return new Vector3(0, 0, 1);
        }
    }
}
