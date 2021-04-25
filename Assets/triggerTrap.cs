using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerTrap : MonoBehaviour
{
    public GameObject arrow;
    // Start is called before the first frame update
    void OnTriggerEnter2D ()
    {
        Instantiate (arrow);
        print("Foi");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
