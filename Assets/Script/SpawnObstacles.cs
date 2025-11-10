using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float maximumX;
    public float minimumX;
    public float maximumY;
    public float minimumY;
    public float timeBetweenSpawn;
    private float spawnTime;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            timeBetweenSpawn = Mathf.Max(1.0f, timeBetweenSpawn * 0.98f);
            spawnTime = Time.time + timeBetweenSpawn;
        }

    }
     void Spawn()
    {
        float randomX = Random.Range(minimumX, maximumX);
        float randomY = Random.Range(minimumY, maximumY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
