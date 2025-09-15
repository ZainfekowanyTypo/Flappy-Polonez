using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButtonScript : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("Game");
    }

    private void Start()
    {
       
    }

    private void Update()
    {
        
    }
}
