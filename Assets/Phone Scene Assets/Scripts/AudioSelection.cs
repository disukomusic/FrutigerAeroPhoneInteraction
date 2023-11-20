using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class AudioSelection : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip[] selectionAudioClips;

    AudioClip SelectionAudio()
    {
        return selectionAudioClips[Random.Range(0, selectionAudioClips.Length)];
    }
}
