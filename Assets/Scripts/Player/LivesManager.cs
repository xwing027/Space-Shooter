using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour
{
    public static float lives = 3;
    public CanvasGroup gameOver;
    public Text livesDisplay;
    public GameObject player;
    public Material invun;
    public Material normalPlayer;
    [SerializeField]
    public bool isInvulnerable;

    public void Update()
    {
        livesDisplay.text = "Lives: " + lives;

        if (lives == 0)
        {
            Time.timeScale = 0;
            Destroy(player);
            gameOver.alpha = 1;
                if (Input.GetButtonDown("Cancel"))
                {
#if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
#endif
                    Application.Quit();
                }
            
        }
        if (isInvulnerable)
        {
            player.tag = "PlayerInvun";
            player.GetComponent<MeshRenderer>().material = invun;
            Invoke("ResetInvun", 3);
        }
            
    }
    void ResetInvun()
    {
        isInvulnerable = false;
        player.tag = "Player";
        player.GetComponent<MeshRenderer>().material = normalPlayer;
    }
}
