using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dano : MonoBehaviour
{
    public int danoo;

    void OnTriggerStay2D(Collider2D other)
    {        
        if(other.tag == "Player")
            other.GetComponent<sis_health>().decrease_health(danoo*other.GetComponent<sis_defence>().defence);
    }
    
}
