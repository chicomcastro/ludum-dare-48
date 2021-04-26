using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comerciante : MonoBehaviour
{
    public GameObject loja;
    void Start()
    {
        loja.SetActive(false);
        
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Player")
            loja.SetActive(true);
        
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
            loja.SetActive(false);
        
    }
}
