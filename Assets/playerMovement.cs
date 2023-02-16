using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float speed_x_constraint;
    public float jumpForce;
    private bool jumping;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        speed_x_constraint = 5f;
        jumpForce = 1f;
        jumping = false;
        speed = 0.1f;

    }

 
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector2(100 * speed, 0f), ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector2(-100 * speed, 0f), ForceMode2D.Force);
        }


        if (rb.velocity.x > speed_x_constraint)
        {
            rb.velocity = new Vector2(speed_x_constraint, rb.velocity.y);
        }

        if (rb.velocity.x < -speed_x_constraint)
        {
            rb.velocity = new Vector2(-speed_x_constraint, rb.velocity.y);
        }

        if (!jumping && Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

        }

    }


   
 
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            jumping = false;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            jumping = true;
        }
    }

 
}

