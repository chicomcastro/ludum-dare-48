using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sis_speed : MonoBehaviour
{
    public float startspeed;
    float speed;
    void Start()
    {
        speed = startspeed;
    }

    public void increase_speed(float n)
    {
        speed += n;
    }
}
