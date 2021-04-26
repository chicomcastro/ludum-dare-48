using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shallow_heart : MonoBehaviour
{
    public GameObject vida;

    public int contador = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(contador > 0)
        {
            vida.GetComponent<quantidadeVida>().multiplicador -= contador;
            contador = 0;
        }
    }
}
