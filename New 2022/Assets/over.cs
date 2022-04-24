using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class over : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("over1"))
        {
            Die();
        }

    }
    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("g_over");
    }
}
