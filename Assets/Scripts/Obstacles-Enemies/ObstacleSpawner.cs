using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject asteroid;
    public GameObject enemy1;
    public GameObject enemy2;
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public Transform pointD;
    Vector3 spawnPos;

    void Start()
    {
        InvokeRepeating("AstSpawn",.2f,.1f); //start spawning asteroids straight away
        InvokeRepeating("E1Spawn", 3f, .8f); //enemy 1 starts spawning
        InvokeRepeating("E2Spawn", 5f, 2f); //enemy 2 starts spawning
    }

    void AstSpawn()
    {
        spawnPos = Vector3.Lerp(pointA.position, pointB.position, Random.Range(0f, 1f)); //spawn randomly between point a and b
        Instantiate(asteroid, spawnPos, Quaternion.identity); //spawn
    }

    void E1Spawn()
    {
        spawnPos = Vector3.Lerp(pointA.position, pointB.position, Random.Range(0f, 1f));
        Instantiate(enemy1, spawnPos, Quaternion.identity);
    }

    void E2Spawn()
    {
        spawnPos = Vector3.Lerp(pointC.position, pointD.position, 0f);
        Instantiate(enemy2, spawnPos, Quaternion.identity);
    }
}
