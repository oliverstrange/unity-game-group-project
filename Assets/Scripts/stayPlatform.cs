using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stayPlatform : MonoBehaviour
{
    //recognise trigger of outer box collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Dog")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Dog")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
