using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    private Rigidbody2D rig;
    private Animator anim;

    public float Speed;
    public Transform rigthCol;
    public Transform leftCol;
    public Transform headPoint;

    private bool colliding;
    public LayerMask layer;

    public CircleCollider2D circleCollider2D;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        rig.velocity = new Vector2(Speed, rig.velocity.y);

        colliding = Physics2D.Linecast(rigthCol.position, leftCol.position, layer);

        if(colliding)
        {

            transform.localScale = new Vector2(transform.localScale.x * - 1, transform.localScale.y);
            Speed  *= -1;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            
            {
                
                GameController.instance.ShowGameOver();
                Destroy(col.gameObject);
            }
        }
    }
}
