using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float speed;


    void Start()
    {
        
    }

    void Update()
    {
        //move
        transform.Translate(Vector3.forward*speed*Time.deltaTime);

        //destroy themselves eventually
        if (transform.position.z > 15 || transform.position.z < -4)
        {
            Destroy(gameObject);
        }
    }
}
