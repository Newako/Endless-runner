using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private void Start()
    {
        SpawnObstacle();
    }

    void Update()
    {
        transform.position += new Vector3(-4, 0, 0) * Time.deltaTime;
    }

    public GameObject obstaclePrefab;
    void SpawnObstacle()
    {
        // Choose a random point to spawn the obstacle
        int obstacleSpawnIndex = Random.Range(1, 3);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        // Spawn the obstacle at the position (I ended up messing up on this code, so it spawn on the sides instead of on the floor. Made it work!)
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
}

