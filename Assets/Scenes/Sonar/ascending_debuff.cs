using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ascending_debuff : MonoBehaviour
{
    public Vector3 direcao;

    void Start()
    {
        direcao = GetComponent<PlatformerMotor2D>()._rigidbody2D.velocity;
    }


    public bool detect_ascending()
    {
        if(direcao.y > 0)
            return true;
        else
            return false;
    }
}
