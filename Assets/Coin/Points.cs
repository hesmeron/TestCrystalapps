using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Points
{
   public static int points = 0;
   public static int bestScore = 0;
    public static void AddPoint()
    {
        points++;
        if(points > bestScore)
        {
            bestScore = points;
        }
    }
    public static void Lose()
    {
        Points.points = 0;
        SceneManager.LoadScene(0);
    }
}
