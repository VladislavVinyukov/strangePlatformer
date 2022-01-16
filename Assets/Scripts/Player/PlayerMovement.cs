using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [HideInInspector] public bool allreadyFinished=false;
    [SerializeField] private float jumpForce;
    [SerializeField] private bool isGrounded=false;
    [SerializeField] private AnimationCurve curve;
    private Rigidbody2D rb;
    private Animator animator;

    //Анимации
    private const string JUMP = "jump";
    private const string IDLE = "idle";
    private const string RUN = "run";

    private void Awake()
    {
        allreadyFinished = false;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    public void Move(float horizontalDirection, bool isJumpButtonPressed)
    {
        if (allreadyFinished) return;

        if (isJumpButtonPressed)
        {
            Jump();
        }
        if (Mathf.Abs(horizontalDirection) > 0.01f)
        {
            HorizontalMovement(horizontalDirection);
        }
        
        if (isGrounded && Mathf.Abs(horizontalDirection) < 0.01f)
        {
            animator.Play(IDLE);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            isGrounded = true;
        }
    }

    private void Jump()
    {
        if (isGrounded)
        {
            animator.Play(JUMP);
            isGrounded = false;
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    private void HorizontalMovement(float direction)
    {
        if (direction >= 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        rb.velocity = new Vector2(curve.Evaluate(direction), rb.velocity.y);
        if (isGrounded) 
        {
            animator.Play(RUN);
        }
        
    }
}
