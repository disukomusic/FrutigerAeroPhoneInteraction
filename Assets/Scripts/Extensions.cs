
using UnityEngine;

public static class Utility
{
    /// <summary>
    /// Takes value t between ina and inb and returns the appropriate lerp between outa and outb.
    /// </summary>
    /// <returns>between outa and outb</returns>
    public static float MapRange(float value, float fromA, float fromB, float toA, float toB, bool clamp = true)
    {
        if (clamp)
        {
            return Mathf.Lerp(toA, toB, Mathf.InverseLerp(fromA, fromB, value));
        }
        else
        {
            return Mathf.LerpUnclamped(toA, toB, Mathf.InverseLerp(fromA, fromB, value));
        }
    }
}
