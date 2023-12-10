using System;
using System.Collections;
using System.Collections.Generic;
using UltimateXR.Manipulation;
using UnityEngine;
using UnityEngine.Serialization;

public class GrabberSound : MonoBehaviour
{

    
    public bool isPlaying;
    [SerializeField] private AudioSource clickSource;
    [SerializeField] private UxrGrabbableObject handle;
    
    private Vector3 _previousPosition;

    void Start()
    {
        _previousPosition = transform.position;
    }

    void Update()
    {
        if (handle.IsBeingGrabbed)
        {
            clickSource.volume = 0.1f;
            Vector3 currentPosition = transform.position;
            float positionDifference = Vector3.Distance(currentPosition, _previousPosition);
            _previousPosition = currentPosition;
            positionDifference /= Time.deltaTime * 0.025f;
            float result = Mathf.Clamp(positionDifference, -1f, 1f);
            
            clickSource.pitch = result;  
        }
        else
        {
            clickSource.volume = 0;
        }
    }
}

