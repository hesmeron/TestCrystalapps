﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundEffectPlayer : MonoBehaviour
{
    [SerializeField]
    AudioClip audioClip;
    [SerializeField]
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    public void PlayEffect()
    {
        Debug.Log("Sound played");
        UniversalAudioSource.audioSource.PlayOneShot(audioClip, 1f);
    }
}
