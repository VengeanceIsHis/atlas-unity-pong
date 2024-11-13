using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode upKey = KeyCode.W;   // The key to move up
    public KeyCode downKey = KeyCode.S; // The key to move down

    public float moveSpeed = 5f;         // Speed at which the player moves

    // Update is called once per frame
    void Update()
    {
        // Get input from the user
        float verticalInput = 0f;

        // Check if the up or down keys are being pressed
        if (Input.GetKey(upKey)) // Move up when W is pressed
        {
            verticalInput = 5f;
        }
        else if (Input.GetKey(downKey)) // Move down when S is pressed
        {
            verticalInput = -5f;
        }

        // Move the GameObject based on input
        Vector3 currentPosition = transform.position;
        currentPosition.y += verticalInput * moveSpeed * Time.deltaTime; // Modify the Y position

        // Set the new position
        transform.position = currentPosition;
    }
}