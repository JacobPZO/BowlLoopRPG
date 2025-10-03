using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalHelper
{
    public static string GenerateUniqueID(GameObject obj)
    {
        return $"{obj.scene.name}_{obj.transform.position.x}_{obj.transform.position.y}_{obj.transform.position.z}";
        //ex. Chest_-10_1_-5
    }
}
