using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeItem : MonoBehaviour
{ 
    public bool isTouching;
    public GameObject desiredPrefab;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Selector"))
        {
            isTouching = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Selector"))
        {
            isTouching = false;
        }
    }

    void BoxInstantiate()
    {
        if (isTouching && desiredPrefab !=null)
        {
            Instantiate(desiredPrefab);
        }
    }
}
