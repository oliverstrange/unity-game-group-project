using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public Animator animator;
    public float moveSpeed = 5f;
    public float jumpForce= 30f;
    public bool grounded;

    // Code below is for fall detection 
    public Vector3 respawnPoint;
    public GameObject fallDetector;
    public GameObject blackOut;
    private float fadeTime = 0.45f; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        respawnPoint = transform.position;
        blackOut.SetActive(false);
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
            animator.SetBool("isWalking", true);
            animator.SetBool("isStanding", false);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            sr.flipX = true;
            animator.SetBool("isWalking", true);
            animator.SetBool("isStanding", false);
        }
        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isStanding", true);
        }

    }

    void jump()
    {
        if ((grounded == true) && Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetBool("isJumping", true);

            Vector2 jump = new Vector2(0, jumpForce);

            rb.AddForce(jump, ForceMode2D.Impulse);
        }

    }

   

   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            grounded = true;
            animator.SetBool("isJumping", false);
        }

        // added code for power up here to avoid repeating code 
        else if(collision.tag == "PowerUp")
        {
            Destroy(collision.gameObject);
            moveSpeed = 15;
            StartCoroutine(EndPower());
        }
  
        else if (collision.tag == "Bounds")
        {
            StartCoroutine(FadeOut());
            transform.position = respawnPoint;

        }
              
        else if (collision.tag == "checkpoint")
        {
            respawnPoint = transform.position;
        }
        
    }

    private IEnumerator EndPower()
    {
        yield return new WaitForSeconds(5);
        moveSpeed = 2;
        
    }

    // Below is a blackout animation between falling and respawning

      private IEnumerator FadeOut()
    {
        blackOut.SetActive(true);
        yield return new WaitForSeconds(fadeTime);

        blackOut.SetActive(false);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            grounded = false;
        }
    }
}

