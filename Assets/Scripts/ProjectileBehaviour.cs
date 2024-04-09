using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadScene

public class ProjectileBehaviour : MonoBehaviour
{
    public float waitTime = 2.0f;



    private void OnTriggerEnter(Collider collision)
    {

        // First check if we collided with the player
        if (collision.CompareTag("Player"))
        {
            // Destroy the player
            Destroy(gameObject);
        }
    }



    private void ResetGame()
    {
        // Restarts the current level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
