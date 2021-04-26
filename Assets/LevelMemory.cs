using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMemory : MonoBehaviour
{
    public int lastLevelLoaded = 0;

    public void SetLevelLoaded(string newValue) {
        lastLevelLoaded = int.Parse(newValue);
    }
}
