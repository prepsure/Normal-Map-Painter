using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Timeline.TimelinePlaybackControls;

namespace MickolPaige.Lab3
{
    [RequireComponent(typeof(Camera))]
    public class OrbitCamera : MonoBehaviour
    {
        [SerializeField]
        Transform FocusOn;

        [SerializeField]
        float Sensitivity = 1;

        [SerializeField]
        float OrbitRadius = 7f;

        Vector3 DirectionFromObject = -Vector3.forward;
        Vector3 CurrentOrbitRotation = new Vector3(45, -45, 0);
        const float Y_LIMIT = 80;

        //TODO clean up
        GameObject emptyGO;

        // Start is called before the first frame update
        void OnEnable()
        {
            // TODO clean up
            emptyGO = new GameObject();

            UserInput inputs = new();

            // TODO unbind this
            inputs.Camera.Orbit.performed += (InputAction.CallbackContext context) =>
            {
                Cursor.lockState = CursorLockMode.Locked;

                Camera cam = GetComponent<Camera>();
                Vector2 delta = new(-context.ReadValue<Vector2>().y, context.ReadValue<Vector2>().x);

                delta = Sensitivity * Vector2.Scale(delta, new Vector2(1f / cam.pixelHeight, 1f / cam.pixelWidth));
                AddRotationDelta(360 * delta);
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

        public Vector3 Focus()
        {
            return FocusOn.position;
        }

        public Transform GetNextCameraTransform()
        {
            // TODO clean this up so we get the transform from somewhere externally
            Transform newTransform = emptyGO.transform;

            newTransform.position = Focus() + Quaternion.Euler(CurrentOrbitRotation) * DirectionFromObject * OrbitRadius;

            newTransform.LookAt(Focus(), Vector3.up);

            return newTransform;
        }

        // Update is called once per frame
        void LateUpdate()
        {
            Transform nextTransform = GetNextCameraTransform();
            transform.SetPositionAndRotation(nextTransform.position, nextTransform.rotation);
        }
    }
}