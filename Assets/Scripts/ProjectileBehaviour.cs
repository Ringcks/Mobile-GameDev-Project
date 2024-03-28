using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadScene

public class ProjectileBehaviour : MonoBehaviour
{
    public float waitTime = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {

        // First check if we collided with the player
        if (collision.CompareTag("Player"))
        {
            // Destroy the player
            Destroy(collision.gameObject);
            // Call the function ResetGame after waitTime
            // has passed

            Invoke("ResetGame", waitTime);
            ResetGame();

            Debug.Log("Hit");
        }
    }



    private void ResetGame()
    {
        // Restarts the current level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
