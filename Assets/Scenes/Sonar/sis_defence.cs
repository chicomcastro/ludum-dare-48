using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sis_defence : MonoBehaviour
{
    
    public float defence = 1; // a ideia aqui eh que se um jogador com defesa x, se um inimigo atacar ele com um ataque da dano y, o dano passa a ser x*y
    public float n;

    public void increase_defence()
    {
        n++;
        defence = 1-n/30;
    }
}
