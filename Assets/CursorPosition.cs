using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorPosition : MonoBehaviour
{
    public Transform targetObject; 

    public float minX;
    public float maxX;

    public float minY;
    public float maxY;

    void Update()
    {
        // Ensure the target object is assigned
        if (targetObject != null)
        {
            float newX = Utility.MapRange(targetObject.transform.localPosition.x,0.395f, -0.817f, minX, maxX);

            float newZ = Utility.MapRange(targetObject.transform.localPosition.z, 0.91f, -0.192f, minY, maxY);
            
            transform.localPosition = new Vector3(newX, newZ, transform.position.z);
        }
       
    }
}
