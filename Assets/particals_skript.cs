using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class particals_skript : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle;
    private void OnCollisionExit2D(Collision2D collision)
    {
        StartCoroutine(offParticle());
        
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        particle.gameObject.SetActive(true);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        particle.gameObject.SetActive(true);

    }
    
    IEnumerator offParticle()
    {
        yield return new WaitForSeconds(0.5f);
       
        particle.gameObject.SetActive(false);
    }
}
