using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Collision : MonoBehaviour
{
    public UnityEvent approachedTrigger;
    
    public UnityEvent awayFromTrigger;

    private void OnTriggerEnter(Collider other)
    {
        approachedTrigger.Invoke();
        
        SFXManager.instance.PlaySound(0);
        // it's by no means an elegant solution..
        // but it does work..
        GameObject.Find("3x4").GetComponent<Animator>().Play("Open");
    }

    private void OnTriggerExit(Collider other)
    {
        awayFromTrigger.Invoke();
        
        SFXManager.instance.PlaySound(1);
        GameObject.Find("3x4").GetComponent<Animator>().Play("Close");
    }
    
    // DEBUG
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SFXManager.instance.PlayRandomSound();
        }
    }
}
