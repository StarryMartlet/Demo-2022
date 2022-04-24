using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;
    private float dirX = 0f;
    [SerializeField]private float moveSpoed = 7f;
    [SerializeField] private float jumpForce = 14f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }


    private void Update()
    {


        dirX = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(dirX * moveSpoed, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        UpdateAnimationUpdate();
    }

    private void UpdateAnimationUpdate()
    {

        if (dirX > 0f)
        {
            anim.SetBool("go", true);
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            anim.SetBool("go", true);
            sprite.flipX = true;
        }
        else 
        {
            anim.SetBool("go", false);
        }
    }
}
