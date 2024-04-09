using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public GameObject playerAttack;
    public List<GameObject> firepointlist = new List<GameObject>();

    private GameObject effectToSpawn;
    private GameObject firepointToInstantiate;
    private GameObject firepointToInstantiate2;
    private float timer;



    // Update is called once per frame
    void Update()
    {
        float randomwIndex3 = 1;

        effectToSpawn = playerAttack;
        firepointToInstantiate = firepointlist[0];
        firepointToInstantiate2 = firepointlist[1];

        float randomValue = Random.value;

        timer += Time.deltaTime;

        if (timer >= randomwIndex3)
        {
            timer = 0;

            SpawnFX();

            //Debug.Log("Attack");
        }
    }

    void SpawnFX()
    {
        GameObject vfx;

        if (firepointToInstantiate != null)
        {
            vfx = Instantiate(effectToSpawn, firepointToInstantiate.transform.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("No Fire Point");
        }

        GameObject vfx2;

        if (firepointToInstantiate2 != null)
        {
            vfx2 = Instantiate(effectToSpawn, firepointToInstantiate2.transform.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("No Fire Point");
        }
    }
}
