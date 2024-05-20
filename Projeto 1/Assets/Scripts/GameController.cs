using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public int totalScore;
    public Text scoreText;
    public GameObject gameOver;

    public static GameController instance;
    public AudioSource audioSource;

    // Start is called before the first frame update
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
        if (audioSource != null)
        {
            audioSource.Stop();
        }
        gameOver.SetActive(true);

    }

    public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }
}
