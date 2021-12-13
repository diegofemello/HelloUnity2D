using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public static GameController instance;
    public Text scoreText;
    
    public GameObject gameOver;

    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }

    public void ShowGameOver()
    {
        Debug.Log("GameOver");
        gameOver.SetActive(true);
    }

    public void RestartGame(string lvlName)
    {
        Debug.Log("Restarting Game");
        SceneManager.LoadScene(lvlName);
    }

    public void NextLevel(string lvlName)
    {
        Debug.Log("Next Level");
        SceneManager.LoadScene(lvlName);
    }
}
