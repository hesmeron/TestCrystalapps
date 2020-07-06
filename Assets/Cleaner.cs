 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner : MonoBehaviour
{
    public static float maxDistance = 15;
    private void Update()
    {
        float distaceX = Mathf.Abs(PlayerMovment.lastPostion.x - this.transform.position.x);
        float distaceZ = Mathf.Abs(PlayerMovment.lastPostion.z - this.transform.position.z);
        if (distaceX > maxDistance || distaceZ > maxDistance){
            Destroy(this.gameObject);
        }
    }
}
