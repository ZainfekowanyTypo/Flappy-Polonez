using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public bool spawnAtTOP = true;
    public bool spawnAtBOTTOM = true;

    public float moveSpeed = 20;
    public float xDeadZone = -40;


    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < xDeadZone)
        {
            Destroy(gameObject);
        }
    }
}
