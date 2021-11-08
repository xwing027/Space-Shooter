using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupHandler : MonoBehaviour
{
    public GameObject bullet;
    public GameObject player;

    public IEnumerator Powerup1()
    {
        Instantiate(bullet, player.transform.position, Quaternion.Euler(0f, 0f, 0f)); //spawn bullets at even angles 
        Instantiate(bullet, player.transform.position, Quaternion.Euler(0f, 45f, 0f));
        Instantiate(bullet, player.transform.position, Quaternion.Euler(0f, 90f, 0f));
        Instantiate(bullet, player.transform.position, Quaternion.Euler(0f, 135f, 0f));
        Instantiate(bullet, player.transform.position, Quaternion.Euler(0f, 180f, 0f));
        Instantiate(bullet, player.transform.position, Quaternion.Euler(0f, 225f, 0f));
        Instantiate(bullet, player.transform.position, Quaternion.Euler(0f, 270f, 0f));
        Instantiate(bullet, player.transform.position, Quaternion.Euler(0f, 315f, 0f));
        Instantiate(bullet, player.transform.position, Quaternion.Euler(0f, 360, 0f));
        yield return new WaitForSeconds(1f); //wait one second
        StartCoroutine("Powerup1"); //spawn bullets again
        yield return new WaitForSeconds(1f);
        StartCoroutine("Powerup1");
        yield return new WaitForSeconds(1f);
        StartCoroutine("Powerup1");
        StopCoroutine("Powerup1"); //stop after 4 times
    }
}
