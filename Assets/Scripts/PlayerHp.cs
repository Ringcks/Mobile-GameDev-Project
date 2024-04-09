using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHp : MonoBehaviour
{

    public float Hp;

    public float MaxHp;
    public float waitTime = 2.0f;
    private bool isTrigger;

    // Start is called before the first frame update
    void Start()
    {
        MaxHp = 1000;
        Hp = MaxHp;
        isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerDie();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(!isTrigger)
        {
            // First check if we collided with the player
            if (collision.CompareTag("Projectile"))
            {
                Hp -= 300;
                isTrigger = true;
                StartCoroutine(ResetTrigger());
            }

            if (collision.CompareTag("Ultimate"))
            {
                Hp -= 1000;
                isTrigger = true;
                StartCoroutine(ResetTrigger());
            }
        }
    }

    public void PlayerHurt()
    {
        Hp -= 1;
        //Debug.Log("Called");
    }

    private void PlayerDie()
    {
        if (Hp <= 0)
        {
            Destroy(gameObject);
            // Call the function ResetGame after waitTime
            // has passed

            Invoke("ResetGame", waitTime);
            ResetGame();

            Debug.Log("PlayerDie");
        }
    }

    private void ResetGame()
    {
        // Restarts the current level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator ResetTrigger()
    {
        yield return new WaitForSeconds(waitTime);
        isTrigger = false;
    }
}
