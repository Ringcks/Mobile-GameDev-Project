using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossBehaviour : MonoBehaviour
{
    public float Hp;

    public float MaxHp;
    public float waitTime = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        MaxHp = 1000;
        Hp = MaxHp;

    }

    // Update is called once per frame
    void Update()
    {
        BossDie();
    }

    private void OnTriggerEnter(Collider collision)
    {

            // First check if we collided with the player
            if (collision.CompareTag("PlayerAttack"))
            {
                Hp -= 10;
                Destroy(collision.gameObject);
            }
    }

    private void BossDie()
    {
        if (Hp <= 0)
        {
            StartCoroutine(EndGame());
            Debug.Log("BossDie");
        }
    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(waitTime);
        // Restarts the current level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
