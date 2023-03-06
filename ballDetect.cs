using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballDetect : MonoBehaviour
{

    public bool ballFallen;
    // Start is called before the first frame update
    void Start()
    {
        ballFallen = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject)
        {
            ballFallen = true;

        }
      
    }
}
