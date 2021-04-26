using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sis_speed : MonoBehaviour
{
    float startspeed = 1;
    public float speed;
    void Start()
    {
        speed = startspeed;
    }

    public void increase_speed(float n) // aumento percentual
    {
        speed *= 1+n/100;
        GetComponent<PlatformerMotor2D>().groundSpeed *= speed;
        GetComponent<PlatformerMotor2D>().timeToGroundSpeed *= speed;
        GetComponent<PlatformerMotor2D>().airSpeed *= speed;
        GetComponent<PlatformerMotor2D>().timeToAirSpeed *= speed;
        GetComponent<PlatformerMotor2D>().ladderSpeed *= speed;
        GetComponent<PlatformerMotor2D>().timeToAirSpeed *= speed;
    }
}
