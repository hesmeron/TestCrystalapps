using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (Text))]
public class Timer : Counter
{
    void Update()
    {
        text.text = Math.Round((Time.timeSinceLevelLoad), 1).ToString();
    }
}
