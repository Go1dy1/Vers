using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Trigger_Particles : MonoBehaviour
{
    //public GameObject particle;
    public ParticleSystem ParticleSystem;
    bool Ground_Check= false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Ground")
        {
            Ground_Check = true;
            //ParticleSystem.Play();
            //Debug.Log("Rabotaet");
        }
        else 
        {
            Ground_Check =false;
            //ParticleSystem.Stop();
            //Debug.Log("NE Rabotaet");
        }
    }
    private void Update()
    {
        if (Ground_Check)
        {
            ParticleSystem.Play();
        }
        else
        {
            ParticleSystem.Stop();
        }
    }

}
