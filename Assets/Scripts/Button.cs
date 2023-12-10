using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Button : MonoBehaviour
{
    
    public TMP_Text tooltip;
    
    public AudioSource confirmAudio;
    public Animator animate;
    public ChangeItem[] items;
        
        
    private bool _canBePressed;
    private Vector3 _originalPos;
    
    
    private void Awake()
    {
        tooltip.text = "Select an app.";
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(_canBePressed);
        Debug.Log("button collided with" + other.gameObject.name);
        if(other.CompareTag("Hand") && _canBePressed)
        {
            _canBePressed = false;
            animate.SetBool("PressButton", true);
            confirmAudio.Play();
            foreach (ChangeItem item in items)
            {
                item.BoxInstantiate();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Hand") && !_canBePressed)
        {
            _canBePressed = true;
            animate.SetBool("PressButton", false);
        }
    }
}
