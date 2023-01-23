using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
    public AudioSource source;

    public void PlaySound(AudioClip clip) {
        if (!source.isPlaying) {
            source.clip = clip;
            source.Play();
        }
    }
}