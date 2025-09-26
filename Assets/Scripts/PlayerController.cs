using UnityEngine;

/// Controls player movement and shooting mechanics for Prototype 2
/// Handles horizontal movement, boundary constraints, and projectile firing
public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float horizontalInput;
    public float speed = 10.0f;

    // Maximum distance player can move left/right from center
    public float xRange = 10;

    [Header("Combat Settings")]
    public GameObject projectilePrefab;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player's current position
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }


        // Clamp player position to stay within bounds on the right side
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // Clamp player position to stay within bounds on the left side
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    }
}
