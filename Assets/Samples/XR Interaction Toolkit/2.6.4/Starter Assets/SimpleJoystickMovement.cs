using UnityEngine;
using UnityEngine.InputSystem; // <- this is enough!

public class SimpleOpenXRJoystickMovement : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    public Transform cameraTransform;

    void Update()
    {
        Vector2 input = Vector2.zero;

        // Read left joystick using InputSystem Gamepad
        if (Gamepad.current != null)
        {
            input = Gamepad.current.leftStick.ReadValue();
        }

        // Move the player
        Vector3 move = cameraTransform.forward * input.y + cameraTransform.right * input.x;
        move.y = 0f; // prevent vertical movement
        transform.position += move * moveSpeed * Time.deltaTime;
    }
}
