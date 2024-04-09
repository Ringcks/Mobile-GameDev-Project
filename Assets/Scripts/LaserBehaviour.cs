using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaserBehaviour : MonoBehaviour
{
    public float waitTime = 2.0f;
    PlayerHp playerHpScript;

    void Start()
    {
        playerHpScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHp>();
    }

    // Start is called before the first frame update
    void OnParticleCollision(GameObject Particle)
    {
        if (Particle.CompareTag("Player"))
        {
            Debug.Log("Hit");
            playerHpScript.PlayerHurt(); 
        }
    }

    // Update is called once per frame
    private void ResetGame()
    {
        // Restarts the current level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
