using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabController : MonoBehaviour
{
    public Transform grabDetect;
    public Transform boxHolder;
    public float rayDist;
   
    // Update is called once per frame
    void Update()
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position,transform.right, rayDist);

        if(grabCheck.collider !=null &&  grabCheck.collider.tag == "bone")

        {
   
                grabCheck.collider.gameObject.transform.SetParent(transform);
                grabCheck.collider.gameObject.GetComponent<Renderer>().enabled = false;
                grabCheck.collider.gameObject.transform.position = boxHolder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;

                GetComponent<Animator>().SetLayerWeight(1, 1f);
                GetComponent<Animator>().SetLayerWeight(0, 0f);

        }
          
    
       
    }
}
