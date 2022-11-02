using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge : MonoBehaviour
{
    Rigidbody2D rb;
    public float forcecharge = 5f;
    public Vector2 moveVector;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Charged();

    }
    public bool ReflectRight = true;
    void ReflectRightbool()
    {
        if ((moveVector.x>0 && !ReflectRight)|| moveVector.x< 0 && ReflectRight)
        {
            transform.localScale *= new Vector2(-1, 1);
            ReflectRight = !ReflectRight;
        }
    }
 void Charged()
    {
        if (Input.GetKey(KeyCode.LeftShift) && LockCharge==false)
        {
            LockCharge = true;
            Invoke("UnLockCharge", 0.7f);

            rb.velocity = new Vector2(0, 0);
            if (rb.transform.localScale.x < 0)
            {
                
                rb.AddForce(Vector2.left * forcecharge);
                
            }
            else
            {
                rb.AddForce(Vector2.right * forcecharge);

            }
          
        }
       
    }
    private bool LockCharge = false;
    void UnLockCharge()
    {
        LockCharge = false;
    }

}
