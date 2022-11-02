using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dumage_Spyke : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name=="Player 1")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("SampleScene");
            
        }

        
    }

    public void Update()
    {
      
    }
    
    

}
