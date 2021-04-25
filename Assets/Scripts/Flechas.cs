using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flechas : MonoBehaviour
{
    public GameObject player, pressure, arrow;

    int contador;

    // Start is called before the first frame update
    void Start()
    {
        contador = 1;
    }

    // Update is called once per frame
    void Update()
    {   
        if(contador == 1)
        {
            if((player.transform.position - pressure.transform.position).magnitude <= 0.1)
            {
                Instantiate (arrow);

                contador--;
            }
        }
    }
}
