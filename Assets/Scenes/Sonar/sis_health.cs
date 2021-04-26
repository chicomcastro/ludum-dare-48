using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sis_health : MonoBehaviour
{
    public double maxhealth;
    public double health;

    public double contador;

    public int dificuldade;

    public GameObject vida;

    void Start()
    {
        health = maxhealth;
    }

    void Update()
    {
        if(health > maxhealth)
            health = maxhealth;

        if(health < maxhealth && health > 0)
        {
            health *= 1.00001;
        }
        if(health <= 0)
        {
            gameObject.GetComponent<LoadLevelByName>().LoadLevel();
        }
    }

    
    public void increase_maxhealth(int n)
    {
        contador += 0.5;
        maxhealth += n;
    }
    public void increase_health(int n)
    {
        health += n;
        if(contador != 0)
        {
            vida.GetComponent<quantidadeVida>().multiplicador -= contador;
            contador = 0;
        }
    }
    public void decrease_health(float n)
    {
        health -= 1;
    }
}
