using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ChangeItem : MonoBehaviour
{ 
    public bool isTouching;
    public GameObject desiredPrefab;
    public Transform objectspawnpoint;
    public AudioSource audioSource;
    public GameObject icon;

    private Vector3 _initialIconScale;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        _initialIconScale = icon.transform.localScale;
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Selector"))
        {
            audioSource.Play();
            isTouching = true;
            icon.transform.localScale += new Vector3(0.00025f, 0.00025f, 0.00025f);
            if (desiredPrefab != null)
            {
                Debug.Log("Currently Selected: " + desiredPrefab.name);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Selector"))
        {
            icon.transform.localScale = _initialIconScale;
            isTouching = false;
        }
    }

    public void BoxInstantiate()
    {
        if (isTouching && desiredPrefab !=null)
        {
            Debug.Log("Instantiated " + desiredPrefab.name);
            Instantiate(desiredPrefab, objectspawnpoint.position,quaternion.identity);
        }
    }

}
