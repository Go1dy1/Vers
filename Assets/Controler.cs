using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour

{
    Rigidbody2D m_rigboddy2D;

   public float m_Speed = 10f;
    Vector2 m_vector2;
    void Start()
    {
        m_rigboddy2D = GetComponent<Rigidbody2D>();

        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
      Walk();
        if (Input.GetKey(KeyCode.D))
        {
            m_rigboddy2D.transform.localScale = new Vector3 (1,1,1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            m_rigboddy2D.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    void Walk()
    {
        m_vector2.x = Input.GetAxis("Horizontal");
        m_rigboddy2D.velocity = new Vector2 (m_vector2.x* m_Speed,m_rigboddy2D.velocity.y );
    }
}
