using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    private PlayerMovement playerMovement;
    private Rigidbody2D rb;

    private bool isDashing;
    private bool isWalking;
    private bool isJumping;
    private bool isFalling;
    private bool isWallJumping;
    private bool isWallSlide;

    private void Awake()
    {
        animator = transform.GetChild(1).GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody2D>();
    
    }


    private void Update()
    {
        //iswalking
        if (playerMovement.horizontal != 0 ) 
        {
            isWalking = true;
        }
        else {
            isWalking = false;
        }

        //wall sliding
        if (playerMovement.IsWalled() && !playerMovement.IsGrounded() && playerMovement.horizontal != 0f)
        {
            isWallSlide = true;
        }
        else
        {
            isWallSlide = false;
        }

        if (Input.GetButtonDown("Jump") && playerMovement.IsGrounded())
        {
            isJumping = true;
        }
        else
        {
            isJumping = false;

        }


        //falling
        if (!playerMovement.IsGrounded() && !isWallSlide && !isJumping)
        {
            isFalling = true;
        }
        else
        {
            isFalling = false;
        }


        //dashing
        if(playerMovement.isDashing && !isWallSlide)
        {
            isDashing = true;
        }
        else
        {
            isDashing = false;
        }



        WalkingAnim();
        SlideWallAnim();
        FallingAnim();
        DashingAnim();
        JumpingAnim();
    }



    private void WalkingAnim()
    {
        if (isWalking)
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
    }


    private void SlideWallAnim()
    {
        if (isWallSlide)
        {
            animator.SetBool("IsSlideWall", true);
        }
        else
        {
            animator.SetBool("IsSlideWall", false);
        }
    }

    private void FallingAnim()
    {
        if (isFalling)
        {
            animator.SetBool("IsFalling", true);
        }
        else
        {
            animator.SetBool("IsFalling", false);
        }
    }

    private void DashingAnim()
    {
        if (isDashing)
        {
            animator.SetBool("IsDashing", true);
        }
        else
        {
            animator.SetBool("IsDashing", false);
        }
    }

    private void JumpingAnim()
    {
        if (isJumping)
        {
            animator.SetBool("IsJumping", true);
        }
        else
        {
            animator.SetBool("IsJumping", false);
        }
    }
}
