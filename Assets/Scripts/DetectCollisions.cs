using UnityEngine;

// Handles collision detection and object cleanup
public class DetectCollisions : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Destroy both the projectile and the target on collision
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
