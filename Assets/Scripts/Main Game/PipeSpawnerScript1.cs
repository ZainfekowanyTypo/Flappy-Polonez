using UnityEngine;

public class PipeSpawnerScript1 : MonoBehaviour
{

    public Obstacle[] spawnBuildings;
    public float spawnRate = 100;
    private float spawnTimer=0;
    public Transform spawnPos;

    void Start()
    {
       spawnObstacle();
    }

    private void Update()
    {
        // timer for spawning pipes
        if (spawnTimer < spawnRate)
        {
            spawnTimer += Time.deltaTime;
        }
        else
        {
            spawnTimer = 0;
            spawnObstacle();
        }
    }

    void spawnObstacle()
    {
        int generatedObstacleIndex = Random.Range(0, spawnBuildings.Length - 1);

        Obstacle generatedObstacle;
        generatedObstacle = spawnBuildings[generatedObstacleIndex];
        

        Instantiate(generatedObstacle.gameObject, spawnPos.position, transform.rotation);
    }
}
