using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Points.points = 0;
            DeathCounter.AddDeath();
            SceneManager.LoadScene(0);
        }
        else
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }

    }
}
