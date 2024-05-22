using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelPoint : MonoBehaviour
{
    public string lvlName;
  

    public void LoadScene1()
    {
  
        SceneManager.LoadScene("lvl_1");
    }

    public void LoadScene2()
    {
 
        SceneManager.LoadScene("lvl_2");
    }

    public void LoadScene3()
    {
  
        SceneManager.LoadScene("lvl_3");
    }

    public void LoadScene4()
    {
   
        SceneManager.LoadScene("lvl_4");
    }

    public void LoadSceneRUN()
    {
     
        SceneManager.LoadScene("RUN...");
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

    public void LoadSceneMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadSceneSelectLevel()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
