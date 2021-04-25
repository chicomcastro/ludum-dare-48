using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sis_health : MonoBehaviour
{
    public double maxhealth;
    public double health;

    void Start()
    {
        health = maxhealth;
    }

    void Update()
    {
        if(health > maxhealth)
            health = maxhealth;
    }

    public void increase_health(int n)
    {
        
        health += n;
        
    }
    public void increase_maxhealth(int n)
    {
        
        maxhealth += n;
    }

    public void decrease_health()
    {
        health -= 1;
    }
}
