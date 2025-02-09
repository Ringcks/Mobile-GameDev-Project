﻿using UnityEngine;
using UnityEngine.SceneManagement; // LoadScene

public class ObstacleBehaviour : MonoBehaviour
{
    [Tooltip("How long to wait before restarting the game")]
    public float waitTime = 2.0f;

    public GameObject explosion;


    /// <summary>
    /// If the object is tapped, we spawn an explosion and
    /// destroy this object
    /// </summary>
    private void PlayerTouch()
    {
        if (explosion != null)
        {
            var particles = Instantiate(explosion, transform.position,
            Quaternion.identity);
            Destroy(particles, 1.0f);
        }
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider collision)
    {
        
        // First check if we collided with the player
        if (collision.gameObject.GetComponent<PlayerBuff>().enabled == true)
        {
            // Destroy the player
            Destroy(collision.gameObject);
            // Call the function ResetGame after waitTime
            // has passed

            Invoke("ResetGame", waitTime);
            ResetGame();
        }
    }
    /// <summary>
    /// Will restart the currently loaded level
    /// </summary>
    private void ResetGame()
    {
        // Restarts the current level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}