using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCounter : Counter
{
    public static int deaths = 0;


    private void Awake()
    {
        deaths = PlayerPrefs.GetInt("deaths");
    }
    void Update()
    {
        text.text = "Deaths:" + deaths.ToString();
    }

    public static void AddDeath()
    {
        deaths++;
        PlayerPrefs.SetInt("deaths", deaths);
    }

    public void Reset()
    {
        PlayerPrefs.SetInt("deaths", 0);
    }
}
