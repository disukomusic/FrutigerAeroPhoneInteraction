using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class SFXManager : MonoBehaviour
{
    // nothing like going to old projects to remember how this stuff works
    // that one memory loss prevention commercial with the jellyfish?
    // i need that. like this is concerning
    public AudioClip[] audioClips;
    public AudioSource _audioSource;
    private Vector3 initPos;

    public static SFXManager instance;

    private void Awake()
    {
        instance = this;
        initPos = transform.position;
    }

    public void PlaySound(int index)
    {
        transform.position = initPos;
        _audioSource.PlayOneShot(audioClips[index]);
    }

    public void PlayRandomSound()
    {
        transform.position = initPos;
        _audioSource.PlayOneShot(audioClips[Random.Range(2, 5)]);
    }
}
