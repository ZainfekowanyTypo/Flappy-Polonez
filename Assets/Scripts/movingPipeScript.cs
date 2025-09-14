using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPipeScript : MonoBehaviour
{
    public float moveSpeed = 20;
    public float xDeadZone = -40;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < xDeadZone )
        {
            gameObject.SetActive(false);
        }
    }
}
