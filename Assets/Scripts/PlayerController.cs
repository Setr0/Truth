using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer spriteRender;
    Animator animator;
    public RuntimeAnimatorController animatorController;
    public Sprite idle;
    string oldDirection = "right";
    string direction = "right";
    public static bool isTouchingGround = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRender = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 6f,
            rb.velocity.y); 

        if(rb.velocity.x > 0f)
        {
            spriteRender.flipX = false;
            animator.runtimeAnimatorController = animatorController;
            direction = "right";
        }

        if (rb.velocity.x < 0f)
        {
            spriteRender.flipX = true;
            animator.runtimeAnimatorController = animatorController;
            direction = "left";
        }

        if (rb.velocity.x == 0f)
        {
            spriteRender.sprite = idle;
            if (direction != oldDirection)
            {
                if(direction == "left") spriteRender.flipX = true;
                if (direction == "right") spriteRender.flipX = false;
                oldDirection = direction;
            }
            animator.runtimeAnimatorController = null;
        }

        if (Input.GetKey(KeyCode.Space) && isTouchingGround)
        {
            rb.velocity = new Vector2(rb.velocity.x,
                6f);
            isTouchingGround = false;
        }
    }
}