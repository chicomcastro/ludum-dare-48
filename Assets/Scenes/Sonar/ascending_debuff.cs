using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ascending_debuff : MonoBehaviour
{
    public Vector2 direcao;
    public int contador_subida;


    void Update()
    {
        direcao = GetComponent<PlatformerMotor2D>().velocity;
        if(detect_ascending())
        {
            contador_subida++;
            print(contador_subida);
        }
    }

    public bool detect_ascending()
    {
        if(direcao.y > 0)
        {
            return true;
        }
        else
            return false;
    }
}
