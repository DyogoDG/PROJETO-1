using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelPoint : MonoBehaviour
{
    public string lvlName;
    public AudioSource audioSource;

    public void LoadScene1()
    {
        audioSource.Play();
        SceneManager.LoadScene("lvl_1");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(lvlName);
        }
    }
    public void LoadSceneCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void LoadScene5()
    {
        SceneManager.LoadScene("lvl_5");
    }

    public void LoadSceneMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
