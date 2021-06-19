using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
   public static int Amove = 0;
    public static bool CanJump = false;
 
    public float speed;
    public float jumpForce;
    private float moveInput;

    private bool facingRigth = true;

    private Rigidbody2D rb;

    public AudioClip _clip;
    public GameObject objAudio;
    private bool isGrounded;
    public bool killEnemy;
    public Transform groundCheck;
    public Transform killZoneCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public LayerMask enemy;
    static Move This = null;


    private int extraJumps;
    public int extraJumpsValue;

    private void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
        This = GetComponent<Move>();
    }

    private void Update()
    {
        if (MenuBut.Pause == true)
        {
            return;
        }
        if (isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }
        Jump();
    }
    public void Jump()
    {
        if ((Input.GetKeyDown(KeyCode.UpArrow) || CanJump) && extraJumps > 0)
        {
            objAudio.GetComponent<AudioSource>().PlayOneShot(_clip);
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }
        else if ((Input.GetKeyDown(KeyCode.UpArrow) || CanJump) && extraJumps == 0 && isGrounded == true)
        {
            objAudio.GetComponent<AudioSource>().PlayOneShot(_clip);
            rb.velocity = Vector2.up * jumpForce;
        }
    }
    public static void JumpPlayer()
    {
        This.Jump();
    }
    private void FixedUpdate()
    {
        if (MenuBut.Pause == true)
        {
            return;
        }
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        killEnemy = Physics2D.OverlapCircle(killZoneCheck.position, 0.2f, enemy);

        moveInput = Input.GetAxis("Horizontal");
        if(Amove == 1)
        {
            moveInput = Amove;
        }
        if (Amove == 2)
        {
            moveInput = -1;
        }

        if (facingRigth == false && (moveInput > 0 ||  Amove == 1))
        {        
            Flip();
        }
        else if (facingRigth == true && (moveInput < 0 || Amove == 2))         
        {
            Flip();
        }
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if(CanJump == true)
        {
            Jump();
            CanJump = false;
        }
    }
    void Flip()
    {
        facingRigth = !facingRigth;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;   
    }
}



    

