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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(lvlName);
        }
    }
}
