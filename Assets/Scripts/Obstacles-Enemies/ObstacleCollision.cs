using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    //public bool isAsteroid = false;
    public PointsHandler pointsHandler;
    LivesManager livesHandler;
    public Vector3 startPos;

    public void Start()
    {
        startPos.Set(0, 0, -1.36f);
        pointsHandler = GameObject.Find("Points Handler").GetComponent<PointsHandler>();
        livesHandler = GameObject.Find("Lives Manager").GetComponent<LivesManager>();
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
            collision.gameObject.transform.position = startPos; //reset position to starting position
            LivesManager.lives--; //take away a life
            livesHandler.isInvulnerable = true;
        }
    }
}
