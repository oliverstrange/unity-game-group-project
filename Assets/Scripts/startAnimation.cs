using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startAnimation : MonoBehaviour

{
    public Animator animator;
    public GameObject player;
    public GameObject camera;
    public GameObject ball;
    public GameObject timer;
    public GameObject timerText;
    public Transform fetch;
    public Transform ballTransform;
    public Transform playerTransform;
    public bool ballCamera;
    public bool playerCamera;
    public Vector3 offset;
    public int speed = 2;
    bool camera_move_enabled = false;



    // Start is called before the first frame update

    void Start()
    {
        ballCamera = false;
        animator.SetBool("gameStarted", true);
        camera.GetComponent<MonoBehaviour>().enabled = false;
        timer.SetActive(false);
        ball.SetActive(false);
        player.SetActive(false);
        timerText.SetActive(false);
        camera.transform.position = new Vector3(fetch.position.x + offset.x, fetch.position.y + offset.y, offset.z);
       


    }

    // Update is called once per frame
    void Update()
    {

        
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f && !animator.IsInTransition(0))
        {
            animator.enabled = false;
            ball.SetActive(true);

            ballCamera = true;
            
        }

        if(ballCamera == true)
        {
            camera.transform.position = new Vector3(ballTransform.position.x + offset.x, ballTransform.position.y + offset.y, offset.z);

        }

        if (ball.GetComponent<ballDetect>().ballFallen == true)
        {
            camera_move_enabled = true;
            timer.SetActive(true);
            player.SetActive(true);

        }

        if (camera_move_enabled)
        {
            ballCamera = false;
            timerText.SetActive(true);
            camera.GetComponent<MonoBehaviour>().enabled = true;
        }

    }
}
