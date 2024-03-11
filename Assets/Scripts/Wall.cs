using UnityEngine;

public class WallCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // If the player collides with this wall, prevent further movement
            // You may need to adjust these values according to your game's setup
            if (transform.position.x < other.transform.position.x)
            {
                // Player collided with the right wall
                // Prevent further movement to the right
                other.GetComponent<Rigidbody>().velocity = new Vector3(Mathf.Min(0, other.GetComponent<Rigidbody>().velocity.x), 0, 0);
            }
            else
            {
                // Player collided with the left wall
                // Prevent further movement to the left
                other.GetComponent<Rigidbody>().velocity = new Vector3(Mathf.Max(0, other.GetComponent<Rigidbody>().velocity.x), 0, 0);
            }
        }
    }
}