using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip Die,Flap,Point,Hit;
    AudioSource audioSource;

    public void PlaySound(AudioClip source)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = source;
        audio.Play();
    }    
}
