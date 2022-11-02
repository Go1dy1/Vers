using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Fly_Enemy : MonoBehaviour
{
    public float speedEnemy;
    public Transform fly_Point;
    public int positionEnemy;
    bool moveingRight;
    Transform player;
    public float stopingDistance;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("SampleScene");

        }
        if (collision.gameObject.name == "EnemyPoint")
        {

        }


    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
