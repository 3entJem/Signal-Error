using Unity.Hierarchy;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this in the Inspector to control speed
    private Rigidbody2D rb;
    private Vector2 movementInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D not found on this GameObject. Please add one.");
        }
    }

    void Update()
    {
        // Get input for horizontal and vertical movement
        movementInput.x = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right Arrow keys
        movementInput.y = Input.GetAxisRaw("Jump"); // W/S or Up/Down Arrow keys

        // Normalize the movement vector to prevent faster diagonal movement
        movementInput.Normalize();
    }

    void FixedUpdate()
    {
        // Apply movement to the Rigidbody2D
        if (rb != null)
        {
            rb.linearVelocity = movementInput * moveSpeed;
        }
    }
}

