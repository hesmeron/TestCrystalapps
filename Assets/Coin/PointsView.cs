using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsView : MonoBehaviour
{
    public Text pointsText, bestText;
    void Update()
    {
        pointsText.text = Points.points.ToString();
        bestText.text = "Best: " + Points.bestScore.ToString();
    }
}
