using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupCollision : MonoBehaviour
{
    public PowerupHandler puHandler;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Powerup1") //if we collect the power up
        {
            puHandler.GetComponent<PowerupHandler>().StartCoroutine("Powerup1"); //run the power up effect

            Destroy(collision.gameObject); //destroy 
        }
    }
}
