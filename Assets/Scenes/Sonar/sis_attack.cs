using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sis_attack : MonoBehaviour
{
    public float attack = 1; //multiplicador de ataque


    public void increase_attack(int n) // n eh percentual
    {
        attack *= 1 + n/100;
    }
}
