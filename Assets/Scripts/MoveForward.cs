using UnityEngine;

// Moves the object forward every frame
public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;

    void Update()
    {
        // Move the object forward at a constant speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
