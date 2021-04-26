using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string sceneName = this.gameObject.GetComponentInParent<LoadLevelByName>().sceneName;
        int levelNumber = int.Parse(sceneName[sceneName.Length - 1].ToString());
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<LevelMemory>().lastLevelLoaded == levelNumber) {
            GameObject.FindGameObjectWithTag("Player").transform.position = this.transform.position;
        }
    }
}
