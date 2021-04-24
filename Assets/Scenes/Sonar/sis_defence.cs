using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sis_defence : MonoBehaviour
{
    
    float defense; // a ideia aqui eh que se um jogador com defesa x, se um inimigo atacar ele com um ataque da dano y, o dano passa a ser x*y
    public int n;
    void Start()
    {
    }

    public void increase_defense()
    {
        n++;
        defense = 1-n/30;

    }
}
