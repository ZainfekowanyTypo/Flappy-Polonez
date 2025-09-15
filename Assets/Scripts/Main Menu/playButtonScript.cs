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

    public void OpenSettings()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    /*
    private void OnApplicationQuit()
    {
        //executed right after Application.Quit();
    }
    */
}
