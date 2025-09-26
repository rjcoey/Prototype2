using UnityEngine;

// Destroys objects that move beyond the screen boundaries
public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    void Update()
    {
        // Clean up projectiles that fly off the top of the screen
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        // If an animal reaches the bottom of the screen trigger game over
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
