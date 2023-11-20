using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collision : MonoBehaviour
{
    // honestly this should just be called Main


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger enter");
        SFXManager.instance.PlaySound(0);
        // it's by no means an elegant solution..
        // but it does work..
        GameObject.Find("3x4").GetComponent<Animator>().Play("Open");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
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
