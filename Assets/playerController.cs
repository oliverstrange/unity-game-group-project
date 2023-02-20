using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public float moveSpeed = 5f;
    public float jumpForce= 30f;
    public bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        jump();
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            sr.flipX = false;
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            sr.flipX = true;
        }
    }

    void jump()
    {
        if ((grounded == true) && Input.GetKeyDown(KeyCode.UpArrow))
        {


            Vector2 jump = new Vector2(0, jumpForce);

            rb.AddForce(jump, ForceMode2D.Impulse);
        }

    }

   

   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            grounded = true;
   
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            grounded = false;
        }
    }
}

