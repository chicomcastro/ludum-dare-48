using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sis_health : MonoBehaviour
{
    
    public int maxhealth;
    int health;

    void Start()
    {
        health = maxhealth;
    }

    void Update()
    {
        
    }

    public void increase_health(public int n)
    {
        health += n;
        if(health > maxhealth)
            health = maxhealth;
    }
}
