using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject asteroid;
    public Transform pointA;
    public Transform pointB;

    void Start()
    {
        InvokeRepeating("Spawn",.2f,.2f);
    }

    void Update()
    {
        
    }

    void Spawn()
    {
        Vector3 spawnPos = Vector3.Lerp(pointA.position, pointB.position, Random.Range(0f, 1f));
        Instantiate(asteroid, spawnPos, Quaternion.identity);
    }
}
