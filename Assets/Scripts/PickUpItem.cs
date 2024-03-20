using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public GameObject pickupEffect;
    public float multiplier = 1.4f;
    public float duration = 4f;
    //public GameObject obstacle; // Assign the obstacle GameObject in the inspector

    public GameObject playerBuff;

    void Start()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBuff>().enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider player)
    {
        
        Instantiate(pickupEffect, transform.position, transform.rotation);
        player.transform.localScale /= multiplier;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBuff>().enabled = false;

        yield return new WaitForSeconds(duration);

        player.transform.localScale *= multiplier;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBuff>().enabled = true;
        Debug.Log("Picked");

        Destroy(gameObject);
    }
}
