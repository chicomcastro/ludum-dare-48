using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float hp = 20f;
    GameObject player;

    int cash;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        hp += player.GetComponent<sis_health>().dificuldade*10;
    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            player.GetComponent<sis_cash>().increasecash();
            Destroy(gameObject);
        }
    }
}
