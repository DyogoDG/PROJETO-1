using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public int Score;
    public AudioClip destroySound;
    private AudioSource audioSource;
    private bool isDestroyed = false;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = destroySound;
        audioSource.playOnAwake = false;
    }

   
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            GameController.instance.totalScore += Score;
            GameController.instance.UpdateScoreText();
            isDestroyed = true;
            audioSource.Play();
            Destroy(gameObject, destroySound.length);


        }
    }
}
