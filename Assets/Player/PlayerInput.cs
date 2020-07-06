using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerInput 
{
    public static void CheckDirection(ref int direction)
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            direction = 0;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            direction = 1;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            direction = 2;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) 
        {
            direction = 3;
        }

    }

    public static bool CheckJumpInput()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
