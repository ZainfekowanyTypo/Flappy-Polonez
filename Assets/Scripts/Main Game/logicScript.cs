using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class logicScript : MonoBehaviour
{
    public int playerScore;

    public TMP_Text playerScoreText;
    public GameObject gameOverScreen;
    public GameObject bird;


    [ContextMenu("Increase Player Score")]

    private void Start()
    {
        // make sure that game over screen is not active
        if (gameOverScreen.activeInHierarchy)
        {
            gameOverScreen.SetActive(false);
        }   
    }

    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        playerScoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void goToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
