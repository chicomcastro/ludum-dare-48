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

    public void increase_health(int n)
    {
        
        health += n;
        if(health > maxhealth)
            health = maxhealth;
    }
    public void increase_maxhealth(int n)
    {
        
        maxhealth += n;
    }
}
