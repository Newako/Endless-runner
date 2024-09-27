/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    [SerializeField] GameObject obstaclePrefab;

    private void Start()
    {
        SpawnObstacle();
    }


    public void SpawnObstacle()
    {
        // Choose a random point to spawn the obstacle
        int obstacleSpawnIndex = Random.Range(1, 3);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        // Spawn the obstacle at the position
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
}
*/