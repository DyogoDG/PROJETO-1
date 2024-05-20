using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mola : MonoBehaviour
{
    private Animator anim;
    public AudioSource audiosourcemola;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public float jumpforce;

    void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
            audiosourcemola.Play();
            anim.SetTrigger("Jump");
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);

            }
        }
}
