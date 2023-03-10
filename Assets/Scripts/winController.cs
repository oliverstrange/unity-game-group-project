using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winController : MonoBehaviour
{

    public bool reachEnd;
    public AudioSource winSound;
    public GameObject player;
    public Canvas winScreen;


    void Awake()
    {
        winScreen.gameObject.SetActive(false);
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "end")
        {
            reachEnd = true;
            Time.timeScale = 0;
            winSound.Play();
            player.SetActive(false);
            winScreen.gameObject.SetActive(true);
            print("win");

        }
        else
        {
            reachEnd = false;
        }
    }
}
