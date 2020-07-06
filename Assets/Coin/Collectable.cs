using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponen(ty]
public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Points.AddPoint();
        Destroy(this.gameObject);
    }
}
