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
        totalPoints += 10;
    }

    public void E1Points()
    {
        totalPoints += 20;
    }

    public void E2Points()
    {
        totalPoints += 40;
    }
}
