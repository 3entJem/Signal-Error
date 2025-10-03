using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform player; // Assign your player GameObject in the Inspector
    public float aheadDistance = 5f; // How far ahead of the player the camera should look
    public float smoothSpeed = 0.125f; // Controls how smoothly the camera follows
    public Vector3 offset; // Optional: Adjust camera height or depth relative to the player

    private void LateUpdate()
    {
        if (player == null)
        {
            Debug.LogWarning("Player Transform not assigned to CameraLookAhead script.");
            return;
        }

        // Calculate the target position ahead of the player
        Vector3 targetPosition = player.position + player.forward * aheadDistance + offset;

        // Smoothly move the camera towards the target position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
        transform.position = smoothedPosition;

        
    }
}


