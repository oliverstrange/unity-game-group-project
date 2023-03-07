using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteakCollisions : MonoBehaviour
{
    public class RemoveOnCollision : MonoBehaviour
    {
        void OnCollisionEnter2D(Collision2D collision)
        {
            // Check if the object collided with has a tag "Remove"
            if (collision.gameObject.CompareTag("player"))
            {
                // Destroy the sprite object
                Destroy(gameObject);
            }
        }
    }
}
