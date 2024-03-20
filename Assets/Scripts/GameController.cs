using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
    public Transform tile;
    public Transform obstacle;
    public Transform pickableItem;

    public Vector3 startPoint = new Vector3(0, 0, -5);
    [Range(1, 15)]
    public int initSpawnNum = 10;
    public int initNoObstacles = 4;

    private Vector3 nextTileLocation;
    private Quaternion nextTileRotation;

    private void Start()
    {
        nextTileLocation = startPoint;
        nextTileRotation = Quaternion.identity;
        for (int i = 0; i < initSpawnNum; ++i)
        {
            SpawnNextTile(i >= initNoObstacles);
        }
    }

    public void SpawnNextTile(bool spawnObstacles = true)
    {
        var newTile = Instantiate(tile, nextTileLocation, nextTileRotation);
        var nextTile = newTile.Find("NextSpawnPoint");
        nextTileLocation = nextTile.position;
        nextTileRotation = nextTile.rotation;


            // Randomly determine whether to spawn an obstacle or a pickable item
            float randomValue = Random.value; // Get a random value between 0 and 1
            if (randomValue <= 0.95f)
            {
                SpawnObstacle(newTile); // Spawn obstacle for 9/10 of the time
            }
            else
            {
                SpawnPickableItem(newTile); // Spawn pick-up item for 1/10 of the time
            }
    }

    private void SpawnObstacle(Transform newTile)
    {
        var obstacleSpawnPoints = new List<GameObject>();
        foreach (Transform child in newTile)
        {
            if (child.CompareTag("ObstacleSpawn"))
            {
                obstacleSpawnPoints.Add(child.gameObject);
            }
        }
        if (obstacleSpawnPoints.Count > 0)
        {
            var spawnPoint = obstacleSpawnPoints[Random.Range(0, obstacleSpawnPoints.Count)];
            var spawnPos = spawnPoint.transform.position;
            var newObstacle = Instantiate(obstacle, spawnPos, Quaternion.identity);
            newObstacle.SetParent(spawnPoint.transform);
        }
    }

    private void SpawnPickableItem(Transform newTile)
    {
        var pickableSpawnPoints = new List<GameObject>();
        foreach (Transform child in newTile)
        {
            if (child.CompareTag("ObstacleSpawn")) // Assuming you have a tag for pickable spawn points
            {
                pickableSpawnPoints.Add(child.gameObject);
            }
        }
        if (pickableSpawnPoints.Count > 0)
        {
            var spawnPoint = pickableSpawnPoints[Random.Range(0, pickableSpawnPoints.Count)];
            var spawnPos = spawnPoint.transform.position;
            var newPickableItem = Instantiate(pickableItem, spawnPos, Quaternion.identity);
            newPickableItem.SetParent(spawnPoint.transform);
        }
    }
}