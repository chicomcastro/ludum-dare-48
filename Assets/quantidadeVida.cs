using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quantidadeVida : MonoBehaviour
{
    int threshold = 20;
    public GameObject player;
    public Sprite half;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<sis_health>().health <= threshold)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = half;
        }

        if(player.GetComponent<sis_health>().health <= threshold - 10)
        {
            Destroy(gameObject);
        }
    }
}
