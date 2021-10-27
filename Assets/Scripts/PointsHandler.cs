using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsHandler : MonoBehaviour
{
    public int totalPoints;
    public Text pointsDisplay;
    public void Update()
    {
        pointsDisplay.text = "Score: " + totalPoints;        
    }

    public void AstPoints()
    {
        Debug.Log("+10");
        totalPoints += 10;
    }
}
