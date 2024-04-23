using UnityEngine;
using UnityEngine.InputSystem;

namespace MickolPaige.Lab3
{
    // A camera that orbits 
    [RequireComponent(typeof(Camera))]
    public class OrbitCamera : MonoBehaviour
    {
        [SerializeField]
        Transform FocusOn; // the object to look at

        [SerializeField]
        float Sensitivity = 1; // sensitivity of the mouse

        [SerializeField]
        float OrbitRadius = 7f; // radius to orbit from

        Vector3 DirectionFromObject = -Vector3.forward; // direction to offset the camera
        Vector3 CurrentOrbitRotation = new Vector3(45, -45, 0); // current rotation of the camera in euler angles
        const float Y_LIMIT = 80; // angle limit for the camera going above/below the object

        void Awake()
        {
            UserInput inputs = new();

            inputs.Camera.Orbit.performed += (InputAction.CallbackContext context) =>
            {
                Cursor.lockState = CursorLockMode.Locked;

                Camera cam = GetComponent<Camera>();

                // normalize sensitivity for different screen sizes
                Vector2 delta = new(-context.ReadValue<Vector2>().y / cam.pixelHeight, context.ReadValue<Vector2>().x / cam.pixelWidth);

                AddRotationDelta(360 * Sensitivity * delta);
            };

            inputs.Camera.OrbitFinished.canceled += (InputAction.CallbackContext context) =>
            {
                Cursor.lockState = CursorLockMode.None;
            };

            inputs.Camera.Enable();
        }

        void AddRotationDelta(Vector3 delta)
        {
            // limit rotation around the x axis between Y_LIMIT and -Y_LIMIT
            CurrentOrbitRotation = new Vector3(
                Mathf.Clamp(
                    CurrentOrbitRotation.x + delta.x, -Y_LIMIT, Y_LIMIT
                ),
                CurrentOrbitRotation.y + delta.y,
                CurrentOrbitRotation.z + delta.z
            );
        }

        // Update is called once per frame
        void LateUpdate()
        {
            transform.position = FocusOn.position + Quaternion.Euler(CurrentOrbitRotation) * DirectionFromObject * OrbitRadius;
            transform.LookAt(FocusOn.position, Vector3.up);
        }
    }
}