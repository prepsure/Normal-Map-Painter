using UnityEngine;

namespace MickolPaige
{
    // Functions for brush behaviors.
    // Will return the vector to draw on the surface from the provided input.
    public static class BrushBehaviors
    {
        // draws a small extruded spherical bump
        public static Vector3 Bump(Vector2 currentPixel, float brushSize, Vector2 postionHit2d, Vector3 positionHit3d, Vector3 normalHit3d)
        {
            Vector2 normalizedToCircle = (currentPixel - postionHit2d) / brushSize;

            return new Vector3(normalizedToCircle.x, normalizedToCircle.y, 1 - normalizedToCircle.magnitude);
        }

        // draws the default face normal in a uv map
        public static Vector3 ResetToFaceNormal(Vector2 currentPixel, float brushSize, Vector2 postionHit2d, Vector3 positionHit3d, Vector3 normalHit3d)
        {
            return new Vector3(0, 0, 1);
        }
    }
}
