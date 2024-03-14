using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    public enum PlayerSide { Left, Right }
    public PlayerSide playerSide;

    float minXBoundary = -10f; // Default minimum X boundary
    float maxXBoundary = -0.5f;  // Default maximum X boundary

    // Adjust the boundaries based on the selected player side
    void Start()
    {
        if (playerSide == PlayerSide.Right)
        {
            // Set the boundaries for the right player
            minXBoundary = 0.5f;
            maxXBoundary = 10f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current position of the player
        Vector3 currentPosition = transform.position;

        // Clamp the X position to stay within the boundaries
        currentPosition.x = Mathf.Clamp(currentPosition.x, minXBoundary, maxXBoundary);

        // Update the player's position
        transform.position = currentPosition;
    }
}
