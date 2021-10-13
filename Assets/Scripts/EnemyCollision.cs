using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{


    void Awake()
    {
        
    }

    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //are we touching another enemy?
        //do nothing

        //are we touching a bullet?
        if (collision.gameObject.tag == "Bullet")
        {
            //destroy bullet, then destroy self
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
        //are we touching the player
        else if (collision.gameObject.tag == "Player")
        {
            //destroy player
            Destroy(collision.gameObject);
        }
    }
}
