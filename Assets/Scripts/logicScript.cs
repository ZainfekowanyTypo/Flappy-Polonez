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
        //bird.SetActive(false);
        //playerScoreText.gameObject.SetActive(false);
    }

    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        playerScoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
