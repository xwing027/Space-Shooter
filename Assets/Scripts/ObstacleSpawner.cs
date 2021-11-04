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
        InvokeRepeating("AstSpawn",.2f,.2f);
        InvokeRepeating("E1Spawn", 3f, .7f);
        InvokeRepeating("E2Spawn", 5f, .7f);
    }

    void AstSpawn()
    {
        spawnPos = Vector3.Lerp(pointA.position, pointB.position, Random.Range(0f, 1f));
        Instantiate(asteroid, spawnPos, Quaternion.identity);
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
