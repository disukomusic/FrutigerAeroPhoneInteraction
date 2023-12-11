using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Springboard : MonoBehaviour
{
    public Animator SpringboardAnimator;
    public AudioSource springSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Object"))
        {
            SpringboardAnimator.SetBool("Bounce", true);
            Vector3 force = new Vector3(-2f, 15f, 5f);
            Rigidbody rigidBody = other.GetComponent<Rigidbody>();
            if (rigidBody != null)
            {
                rigidBody.AddForce(force, ForceMode.Impulse);
                springSound.Play();
            }  
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        
        SpringboardAnimator.SetBool("Bounce", false);
    }
}
