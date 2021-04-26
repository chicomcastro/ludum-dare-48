using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quantidadeVida : MonoBehaviour
{
    public int threshold = 20;
    public GameObject player;
    public double aux;

    public Sprite half;
    public Sprite full;
    public double multiplicador = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        if (player == null) {
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {   
            if(player.GetComponent<sis_health>().health < threshold)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = half;
            }

            if(player.GetComponent<sis_health>().health <= threshold - 10)
            {
                Destroy(gameObject);
            }

            if(player.GetComponent<sis_health>().health >= threshold)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = full;
            }

            if(player.GetComponent<sis_health>().health > threshold && multiplicador == 1)
            {
                threshold += 20;
                Instantiate(gameObject, new Vector3(gameObject.GetComponent<Transform>().position.x + 1, gameObject.GetComponent<Transform>().position.y, gameObject.GetComponent<Transform>().position.z), Quaternion.identity); 
                threshold -= 20;
                multiplicador++;
            }

            if(player.GetComponent<sis_health>().health > threshold && multiplicador < 1)
            {
                threshold += 20;
                aux = multiplicador;
                multiplicador = 2;
                Instantiate(gameObject, new Vector3(gameObject.GetComponent<Transform>().position.x + 1, gameObject.GetComponent<Transform>().position.y, gameObject.GetComponent<Transform>().position.z), Quaternion.identity); 
                threshold -= 20;
                multiplicador = aux;
                multiplicador++;
            }
    }
}
