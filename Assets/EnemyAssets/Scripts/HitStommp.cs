using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStommp : MonoBehaviour
{
    public float bounce;
    public Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            rb2D.velocity = new Vector2(rb2D.velocity.x, bounce);
        }
    }
}
