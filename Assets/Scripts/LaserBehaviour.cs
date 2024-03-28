using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaserBehaviour : MonoBehaviour
{
    public float waitTime = 2.0f;

    // Start is called before the first frame update
    private void OnParticleCollision(GameObject Particle)
    {
        if (Particle.CompareTag("Player"))
        {
            // Destroy the player
            Destroy(Particle.gameObject);
            // Call the function ResetGame after waitTime
            // has passed

            Invoke("ResetGame", waitTime);
            ResetGame();

            Debug.Log("Hit");
        }
    }

    // Update is called once per frame
    private void ResetGame()
    {
        // Restarts the current level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
