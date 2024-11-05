using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAndEnemySpawn : MonoBehaviour
{
    // Changed it to a list so then multiple things can be spawned
    public List<GameObject> obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;

    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX,maxX);
        float randomY = Random.Range(minY, maxY);

        // Random Selection of Obstacles
        int randomIndex = Random.Range(0, obstacle.Count);
        GameObject obstacleToSpawn = obstacle[randomIndex];

        Instantiate(obstacleToSpawn, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
