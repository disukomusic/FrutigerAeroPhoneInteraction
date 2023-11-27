using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectorSpawnIn : MonoBehaviour
{
    private void Awake()
    {
        transform.localScale = Vector3.zero;
    }

    public void SpawnSelector()
    {
        StartCoroutine(ScaleUp());
    }

    public void DespawnSelector()
    {
        StartCoroutine(ScaleDown());
    }
    
    IEnumerator ScaleUp()
    {
        float targetScale = 0.1770629f;
        float duration = 0.5f;

        Vector3 originalScale = transform.localScale;
        Vector3 targetScaleVector = new Vector3(targetScale, targetScale, targetScale);

        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            transform.localScale = Vector3.Lerp(originalScale, targetScaleVector, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the scale is set to the exact target value to avoid any precision issues
        transform.localScale = targetScaleVector;
    }

    IEnumerator ScaleDown()
    {
        float targetScale = 0f;
        float duration = 0.5f;

        Vector3 originalScale = transform.localScale;
        Vector3 targetScaleVector = new Vector3(targetScale, targetScale, targetScale);

        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            transform.localScale = Vector3.Lerp(originalScale, targetScaleVector, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the scale is set to the exact target value to avoid any precision issues
        transform.localScale = targetScaleVector;
    }
}
