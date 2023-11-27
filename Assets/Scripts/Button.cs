using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Button : MonoBehaviour
{
    
    [FormerlySerializedAs("setSailText")] public TMP_Text tooltip;
    
    public AudioSource confirmAudio;
    public Animator animate;

    private bool _canBePressed;
    private Vector3 _originalPos;
    
    
    private void Awake()
    {
        tooltip.text = "Select an app.";
    }

    void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("button collided with" + other.gameObject.name);
        if(other.CompareTag("Player") && _canBePressed)
        {
            _canBePressed = false;
            OnButtonPress();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player") && !_canBePressed)
        {
            _canBePressed = true;
        }
    }

    private void OnButtonPress()
    {
        animate.SetTrigger("PressButton");
    }

}
