using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SoundEffectPlayer))]
public class Collectable : MonoBehaviour
{
    SoundEffectPlayer player;
    private void Start()
    {
        player = this.gameObject.GetComponent<SoundEffectPlayer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Points.AddPoint();
        player.PlayEffect();
        Destroy(this.gameObject);
    }
}
