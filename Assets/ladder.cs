using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour
{
    public float speed = 10;
    Vector2 aux;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay2D(Collider2D other)
    {        
        if (other.tag == "Player" && Input.GetKey(KeyCode.W))
        {
            other.GetComponent<PlatformerMotor2D>().velocity = new Vector2(0, speed);
        }

        else if (other.tag == "Player" && Input.GetKey(KeyCode.S))
        {
            other.GetComponent<PlatformerMotor2D>().velocity = new Vector2(0, -speed);
        }

        else
        {
            aux = new Vector2(other.GetComponent<PlatformerMotor2D>().velocity.x, 0);
            other.GetComponent<PlatformerMotor2D>().velocity = aux;
        }
    }

}
