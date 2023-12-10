using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeItem : MonoBehaviour
{ 
    public bool isTouching;
    public GameObject desiredPrefab;
    
    public Transform objectspawnpoint;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BoxInstantiate();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Selector"))
        {
            isTouching = true;
            Debug.Log("Currently Selected: " + other.name);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Selector"))
        {
            isTouching = false;
        }
    }

    public void BoxInstantiate()
    {
        if (isTouching && desiredPrefab !=null)
        {
            Debug.Log("Instantiated " + desiredPrefab.name);
            Instantiate(desiredPrefab, objectspawnpoint);
        }
    }

}
