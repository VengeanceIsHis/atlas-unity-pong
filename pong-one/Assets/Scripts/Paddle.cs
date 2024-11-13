using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    // Define the boundaries for the movement
    public float minX = -5f;
    public float maxX = 5f;
    public float minY = 0f;
    public float maxY = 300f;

    void Update()
    {
        // Clamp the position to keep the object within the defined boundaries
        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        float clampedY = Mathf.Clamp(transform.position.y, minY, maxY);

      
    }
}
