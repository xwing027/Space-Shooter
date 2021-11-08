using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject pu1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("P1Spawn", 10f, 30f); //spawn the power up
    }

    void P1Spawn()
    {
        Instantiate(pu1, transform.position, Quaternion.identity);
    }
}
