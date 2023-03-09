using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winController : MonoBehaviour
{

    public bool reachEnd;
    public AudioSource winSound;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "end")
        {
            reachEnd = true;
            print("win");
            winSound.Play();


        }
        else
        {
            reachEnd = false;
        }
    }
}
