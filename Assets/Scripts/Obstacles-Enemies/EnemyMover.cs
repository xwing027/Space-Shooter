using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public float speed;
    void Update()
    {
        //move - so far this handles all obstacles the same way
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        //destroy themselves eventually
        if (transform.position.z > 15 || transform.position.z < -4)
        {
            Destroy(gameObject);
        }
    }
}
