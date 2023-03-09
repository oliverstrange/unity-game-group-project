using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public Animator animator;
    public float moveSpeed = 5f;
    public float jumpForce= 30f;
    public bool grounded;
    public AudioSource jumpSound;
    public AudioSource eatSound;

    // Code below is for fall detection 
    public Vector3 respawnPoint;
    public GameObject fallDetector;
    public GameObject blackOut;
    private float fadeTime = 0.45f;

    //Life variables

    Health playerHealth;
    private bool hasTakenDamage = false;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        respawnPoint = transform.position;
        blackOut.SetActive(false);

        healthBar = GameObject.FindWithTag("Health");
        dogLife = healthBar.GetComponent<AvatarLifeManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        jump();
        playerHealth = GetComponentInParent<Health>();
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

            if (jumpSound != null)

            {
                jumpSound.Play();
            }

            rb.AddForce(jump, ForceMode2D.Impulse);
        }

    }

   

   void OnTriggerEnter2D(Collider2D collision)
    {
        //User is moving
        if (collision.tag == "Platform")
        {
            grounded = true;
            animator.SetBool("isJumping", false);
            hasTakenDamage = false;
        }

      
        //Trap effect
        if (collision.gameObject.tag == "Trap")
        {
            GetComponent < SpriteRenderer>().color = Color.red; 
            moveSpeed = 1;
            StartCoroutine(EndPower());

        }

        //Power up
        else if(collision.tag == "PowerUp")
        {
            Destroy(collision.gameObject);
            moveSpeed = 15;
            StartCoroutine(EndPower());
        }
  

        //falls out of bounds
        else if (collision.tag == "Bounds")
        {
            if (!hasTakenDamage)
            {
                hasTakenDamage = true;
                Debug.Log("Dog fell off platform");
                StartCoroutine(FadeOut());
                transform.position = respawnPoint;
                playerHealth.TakeDamage(1);
            }

        }
        //Reached a checkpoint      
        else if (collision.tag == "checkpoint")
        {
            respawnPoint = transform.position;
            Debug.Log("Checkpoint reached");
        }

        //Dog Food eaten
        else if (collision.tag == "DogFood")
        {
            playerHealth.AddHealth(1);
 
            Destroy(collision.gameObject);
            Debug.Log("Collided with the food");

            if (eatSound != null)
            {
                eatSound.Play();
            }
            dogLife.AddLife();
            
        }

    }

   private IEnumerator EndPower()
   {
       yield return new WaitForSeconds(2);
       moveSpeed = 2;
       GetComponent<SpriteRenderer>().color = Color.white;
        
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

