using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerojLive : MonoBehaviour
{
    private Rigidbody2D  rb;
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            Die();
        }

    }
    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }
}
