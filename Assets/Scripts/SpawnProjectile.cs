using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{

    public List<GameObject> vfx = new List<GameObject>();
    public GameObject Ultimate;
    public List<GameObject> firepointlist = new List<GameObject>();

    private GameObject effectToSpawn;
    private GameObject Ulti;
    private GameObject firepointToInstantiate;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int randomIndex = Random.Range(0, vfx.Count);
        int randomIndex2 = Random.Range(0, firepointlist.Count);
        float randomwIndex3 = Random.Range(5, 10);

        effectToSpawn = vfx[randomIndex];
        Ulti = Ultimate;
        firepointToInstantiate = firepointlist[randomIndex2];

        float randomValue = Random.value;

        timer += Time.deltaTime; 

        if (timer >= randomwIndex3 && randomValue < 0.9) 
        {
            timer = 0;

            SpawnFX();

            Debug.Log("Boss attack");
        }
        else if(timer >= randomwIndex3 && randomValue >= 0.9)
        {
            timer = 0;

            SpawnUltimate();

            Debug.Log("Boss ulti");
        }

    }
        
    void SpawnFX()
    {
        GameObject vfx;

        if(firepointToInstantiate != null)
        {
            vfx = Instantiate (effectToSpawn, firepointToInstantiate.transform.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("No Fire Point");
        }
    }

    void SpawnUltimate()
    {
        GameObject Ultimate;

        if (firepointToInstantiate != null)
        {
            Ultimate = Instantiate(Ulti, firepointToInstantiate.transform.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("No Fire Point");
        }
    }
}
