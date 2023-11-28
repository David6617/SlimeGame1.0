using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //this is like calling a class on java
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject GameOverScreen;

    [ContextMenu("addscore")]
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver() { 
        GameOverScreen.SetActive(true);
    }
}
