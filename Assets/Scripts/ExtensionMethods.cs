using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethods 
{
    public static void RandomiseRotation(this Transform trans, string newName)
    {
        float minValue = 0;
        float maxValue = 360;
        var newX = Random.Range(minValue, maxValue);
        var newY = Random.Range(minValue, maxValue);
        var newZ = Random.Range(minValue, maxValue);
        trans.rotation = Quaternion.Euler(newX, newY, newZ);

        trans.gameObject.name = newName;
    }
}
