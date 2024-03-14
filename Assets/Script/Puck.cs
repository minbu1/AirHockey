using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour
{
    public Collider2D colliderToIgnore;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Ignore collisions with the specified collider
        if (collision.collider == colliderToIgnore)
        {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>(), true);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // Re-enable collisions when the collider exits
        if (collision.collider == colliderToIgnore)
        {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>(), false);
        }
    }
}
