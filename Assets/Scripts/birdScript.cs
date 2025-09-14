using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidbody;
    public logicScript logic;

    public float flapStrength;
    public bool birdIsAlive = true;


    public static birdScript Instance;

    void Start()
    {
        Instance = this;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && birdIsAlive)
        {
            birdRigidbody.linearVelocity = Vector2.up * flapStrength;
        }

        if (transform.position.y > 14.75f)
        {
            transform.position = new Vector3(transform.position.x, 14.75f, transform.position.z);
        } 
        else if (transform.position.y < -18f)
        {
            logic.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
