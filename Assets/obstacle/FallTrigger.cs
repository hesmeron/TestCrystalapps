using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") {
            other.GetComponent<Rigidbody>().useGravity = true;
            Destroy(other.GetComponent<PlayerMovment>());
        }
        else
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
