using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float hp = 100f;
    public GameObject player;

    int cash;
    
    // Start is called before the first frame update
    void Start()
    {
        
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
