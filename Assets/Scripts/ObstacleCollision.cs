using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    //public bool isAsteroid = false;
    public PointsHandler pointsHandler;

    public void Start()
    {
        pointsHandler = GameObject.Find("Points Handler").GetComponent<PointsHandler>();
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
            if (gameObject.tag =="Asteroid")
            {
                pointsHandler.AstPoints();
            }
            if (gameObject.tag == "Enemy1")
            {
                pointsHandler.E1Points();
            }
            if (gameObject.tag == "Enemy2")
            {
                pointsHandler.E2Points();
            }
        }

        //are we touching the player
        else if (collision.gameObject.tag == "Player")
        {
            //destroy player
            Destroy(collision.gameObject);
        }
    }
}
