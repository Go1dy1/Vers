using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SSpawn : MonoBehaviour
{
    public GameObject Character;
    
    public Transform sspawn;
    public Vector2 sspawnPosition = new Vector2 (0,0);
    void Start()
    {

        Character = GameObject.FindGameObjectWithTag("Playerr");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
