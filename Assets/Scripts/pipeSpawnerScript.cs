using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;

    public float spawnRate = 100;
    public float yOffset = 10;

private float timer = 0;

    void Start()
    {
        spawnPipe();
    }

    void Update()
    {
        // timer for spawning pipes
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            spawnPipe();
        }
    }
    void spawnPipe()
    {
        float lowestSpawnPoint = transform.position.y - yOffset;
        float highestSpawnPoint = transform.position.y + yOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestSpawnPoint, highestSpawnPoint), 0), transform.rotation);
    }
}
