using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed;
    public GameObject bullet;

    void Update()
    {
        Vector3 movement;
        //assigns the x and z axis for player movement - y isn't needed for top-down projects
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = 0;
        movement.z = Input.GetAxisRaw("Vertical");
        //make the vector framerate independent - putting this here also means we dont have to *deltatime and speed again 
        movement *= Time.deltaTime;
        movement *= speed;

        //move by what we determined above w/ movement
        transform.Translate(movement);

        //can shoot
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet,transform.position,transform.rotation);
        }

        //can get killed by enemy

        //clamp players position to inside the play field
        Vector3 clampPos = transform.position;
        clampPos.x = Mathf.Clamp(clampPos.x,-13,13);
        clampPos.z = Mathf.Clamp(clampPos.z, -2,12);
        clampPos.y = 0;

        transform.position = clampPos;
    }
}
