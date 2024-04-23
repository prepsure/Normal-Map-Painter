using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MickolPaige
{

    // Functions for different brush shapes.
    // Each function will return true if the currentPixel is within its shape, false otherwise.
    public static class BrushShapes
    {
        public static bool Circle(Vector2 currentPixel, float brushSize, Vector2 postionHit2d, Vector3 positionHit3d)
        {
            return (currentPixel - postionHit2d).magnitude <= brushSize / 2;
        }

        public static bool Square(Vector2 currentPixel, float brushSize, Vector2 postionHit2d, Vector3 positionHit3d)
        {
            Vector2 diff = currentPixel - postionHit2d;

            return Mathf.Abs(diff.x) < brushSize / 2 && Mathf.Abs(diff.y) < brushSize / 2;
        }

    }
}
