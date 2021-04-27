using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portas : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject porta_ui;
    void Start()
    {
        porta_ui.SetActive(false);
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
            porta_ui.SetActive(true);
        
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
            porta_ui.SetActive(false);
        
    }
}
