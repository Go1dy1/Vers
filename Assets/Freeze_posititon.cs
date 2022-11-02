using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze_posititon : MonoBehaviour
{
    Rigidbody2D Character;
    bool isColision;

    private void Start()
    {
        Character = GetComponent<Rigidbody2D>();
    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Ground")
        {
            isColision = true;
        } 
        
    }
    private void LateUpdate()
    {
        if (!isColision)
        {
            Character.constraints = RigidbodyConstraints2D.FreezeRotation;
            

        }
        else
        {
            Character.constraints = RigidbodyConstraints2D.FreezeAll;
            
            isColision = false;
        }
    }
}
