using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Vector2 direction = new Vector2(0,1);
    Rigidbody2D jumper;
    public float jumpSpeed;
    public float FallAfterJump = 2f;

    

   // private float falling = 0.02f;
    void Start()
    {
        jumper = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        IsJump();


        PlatformCheck();
        GroundCheck();
        
    }
   public bool IsGround= false ;
   public Transform groundCheck;
   public float RadiusGroundCheck = 0.5f;
   public LayerMask Ground;
    public LayerMask Platform;
    bool ground= false;
    bool platform= false;
    public bool pplatform= false;



    private bool LockJump = false;

    void UnLockCharge()
    {
        LockJump = false;
    }

    void IsJump()
    {
        if (Input.GetKey(KeyCode.Space) && IsGround && !pplatform && LockJump == false)
        {
            LockJump = true;
            Invoke("UnLockCharge", 0.7f);

            jumper.AddForce(direction * jumpSpeed,ForceMode2D.Impulse);
            IsGround = false ;
        }
       else if (Input.GetKey(KeyCode.Space) && pplatform && !IsGround && LockJump == false)
        {
            LockJump = true;
            Invoke("UnLockCharge", 0.7f);

            jumper.AddForce(direction * jumpSpeed, ForceMode2D.Impulse);
            pplatform = false;
        }
        if (jumper.velocity.y < 0)
        {
            jumper.velocity += Vector2.up * Physics2D.gravity.y * (FallAfterJump - 1) * Time.deltaTime;
        }
    }
    void GroundCheck()
    {


        IsGround = Physics2D.OverlapCircle(groundCheck.position, RadiusGroundCheck, Ground);
    }
    void PlatformCheck()
    {
        pplatform= Physics2D.OverlapCircle(groundCheck.position, RadiusGroundCheck, Platform);
    }
}
