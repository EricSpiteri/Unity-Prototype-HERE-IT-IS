using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveSpeed = 8f; // Speed at which the platform moves
    public float minX = 0;
    public float maxX = 10; // Minimum and maximum X positions

    private bool movingRight = true;

    void Update()
    {
        // Move the platform back and forth
        if (movingRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

            if (transform.position.x >= maxX)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

            if (transform.position.x <= minX)
            {
                movingRight = true;
            }
        }
    }
}

