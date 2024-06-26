using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public bool isJumping;
    public bool doubleJumping;

    private Rigidbody2D rig;
    private Animator anim;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;

        if (Input.GetAxis("Horizontal") > 0f)
        {
            anim.SetBool("walk", true);
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (Input.GetAxis("Horizontal") < 0f)
        {
            anim.SetBool("walk", true);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            anim.SetBool("walk", false);
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (!isJumping)
            {
                audioSource.Play();
                rig.velocity = new Vector2(rig.velocity.x, 0f); // Reseta a velocidade vertical
                rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                isJumping = true;
                doubleJumping = true;
            }
            else if (doubleJumping)
            {
                audioSource.Play();
                rig.velocity = new Vector2(rig.velocity.x, 0f); // Reseta a velocidade vertical
                rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                doubleJumping = false;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isJumping = false;
        }
        if (collision.gameObject.tag == "Water")
        {
            GameController.instance.ShowGameOver();
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Spike")
        {
            GameController.instance.ShowGameOver();
            Destroy(gameObject);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        isJumping = true;
    }
}