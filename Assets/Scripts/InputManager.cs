//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

////too complicated dont use
//public class InputManager : MonoBehaviour
//{
//    private Rigidbody2D rb;
//    private BoxCollider2D boxCollider2D;
//    private Animator playerAnimator;
//    private SpriteRenderer spriteRenderer;

//    private float h;
//    //dash
//    private bool canDash = true;
//    private bool isDashing;
//    private float dashingPower = 6f;
//    private float dashingTime = 0.2f;
//    private float dashingCooldown = 1f;
//    [SerializeField] private TrailRenderer tr;
//    [SerializeField] private TrailRenderer dtr;
//    //enddash
//    [Header("Movement")]
//    //movement
//    public float moveSpeed;
//    public float jumpSpeed;
//    public float boxcastDistance;
//    //movement
//    [Header("Wall Jump")]
//    //walljump
//    public Transform wallCheck;
//    private bool isWallTouch;
//    private bool isSlidingWall;
//    public float wallSlidingSpeed;
//    public Vector2 wallJumpKick;
//    public bool wallJumpCooldownBool = false;
//    public float wallJumpCooldownTime;
//    public float wallJumpCooldownTimeStart = 0;



//    private bool facingRight = true;
//    [Header("Obstacle Layermask")]
//    public LayerMask layerMask;
//    [Header("JumpableWall Layermask")]
//    public LayerMask wallLayerMask; 


//    private void Awake()
//    {
//        //get the needed components from GO-s
//        rb = GetComponent<Rigidbody2D>();
//        boxCollider2D = GetComponent<BoxCollider2D>();
//        playerAnimator = GetComponentInChildren<Animator>();
//        spriteRenderer = GetComponentInChildren<SpriteRenderer>();

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        h = Input.GetAxisRaw("Horizontal");
//        if (IsGrounded() && isDashing)
//        {
//            playerAnimator.SetBool("IsDashing", true);
//            BoxColliderSetDashing();
//        }

//        if (isDashing)
//        {
//            return;
//        }
//        //moving



//        //Jumping + Animation

//        if (Input.GetButton("Jump") && IsGrounded()){

//            rb.velocity = new Vector2(rb.velocity.x,jumpSpeed);
//            playerAnimator.SetBool("IsFalling", true);
//        }
//        else if (Input.GetButton("Jump") && isSlidingWall && !wallJumpCooldownBool)
//        {
//            isSlidingWall = false;
//            rb.velocity = new Vector2(-h * wallJumpKick.x, wallJumpKick.y);
//            playerAnimator.SetBool("IsFalling", true);
//            wallJumpCooldownBool = true;
//        }
//        else
//        {
//            rb.velocity = new Vector2((h * moveSpeed), rb.velocity.y);

//            if (!IsGrounded())
//            {
//                playerAnimator.SetBool("IsFalling", true);
//            }
//            else
//            {
//                playerAnimator.SetBool("IsFalling", false);
//            }
//        }



//        //Walking Animation

//        if (h !=0)
//        {
//            playerAnimator.SetBool("IsWalking", true);
            
//        }
//        else { 
//            playerAnimator.SetBool("IsWalking", false); 
//        }

//        if (h > 0 && !facingRight)
//        {
//            Flip();
//        }
//        if (h < 0 && facingRight)
//        {
//            Flip();
//        }

//        //dashing
//        if(Input.GetKeyDown(KeyCode.LeftShift) && canDash)
//        {
//            StartCoroutine(Dash());
//        }

//        //walljump
//        Collider2D wallCollider = Physics2D.OverlapBox(wallCheck.position, new Vector2(0.03f, 0.2f), wallLayerMask);

//        if(wallCollider != boxCollider2D) { 
//            isWallTouch = true;
//        }
//        else { isWallTouch = false; }


//        if (isWallTouch && !IsGrounded() && h != 0)
//        {
//            isSlidingWall = true;
//        }
//        else
//        {
//            isSlidingWall = false;
//        }

//        ///////////////////

//        if (isSlidingWall)
//        {
//            rb.velocity = new Vector2(rb.velocity.x, Mathf.Clamp(rb.velocity.y, wallSlidingSpeed, float.MaxValue));
//        }

//        if (wallJumpCooldownBool)
//        {
//            if (wallJumpCooldownTime > wallJumpCooldownTimeStart) {
//                wallJumpCooldownTimeStart = wallJumpCooldownTimeStart + 1 * Time.deltaTime;
//            }
//            else { 
//                wallJumpCooldownTimeStart = 0;
//                wallJumpCooldownBool = false;
//            }
//            print(wallJumpCooldownTimeStart);
//        }
//    }


//    private void Flip()
//    {
//        Vector3 currentScale = gameObject.transform.localScale;
//        currentScale.x *= -1;
//        gameObject.transform.localScale = currentScale;

//        facingRight = !facingRight;
//    }


//    //true if the player is grounded, false if not
//    private bool IsGrounded()
//    {
//        var originPosition = new Vector2(transform.position.x, transform.position.y);
//        return Physics2D.BoxCast(originPosition + boxCollider2D.offset, boxCollider2D.size, 0, new Vector2(0, -1), 0.1f, layerMask);
//        //change the new Vector2(0, -1) to Vector2.down ??
//    }

//    private IEnumerator Dash()
//    {
//        canDash = false;
//        isDashing = true;
//        float originalGravity = rb.gravityScale;
//        rb.gravityScale = 0f;
//        rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
//        if (IsGrounded())
//        {
//            dtr.emitting = true;
//        }
//        else
//        {
//            tr.emitting = true;
//        }

//        yield return new WaitForSeconds(dashingTime);
//        dtr.emitting = false;
//        tr.emitting = false;
//        rb.gravityScale = originalGravity;
//        isDashing = false;
//        playerAnimator.SetBool("IsDashing", false);
//        BoxColliderSetNormal();
//        yield return new WaitForSeconds(dashingCooldown);
//        canDash = true;
//    }

    
//    public void BoxColliderSetNormal()
//    {
//        boxCollider2D.offset = new Vector2(0f, -0.03f);
//        boxCollider2D.size = new Vector2(0.1f, 0.2f);

//    }

//    public void BoxColliderSetDashing()
//    {
//        boxCollider2D.offset = new Vector2(0f, -0.13f);
//        boxCollider2D.size = new Vector2(0.2f, 0.1f);

//    }
//}
