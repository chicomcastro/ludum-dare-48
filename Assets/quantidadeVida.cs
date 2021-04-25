using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quantidadeVida : MonoBehaviour
{
    public int threshold = 20;
    public GameObject player;
    public Sprite half;
    public int multiplicador = 1;
    // Start is called before the first frame update
    void Start()
    {
        
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
                multiplicador--;
            }

            if(player.GetComponent<sis_health>().health > threshold && multiplicador == 1)
            {
                threshold += 20;
                Instantiate(gameObject, new Vector3(gameObject.GetComponent<Transform>().position.x + 1, gameObject.GetComponent<Transform>().position.y, gameObject.GetComponent<Transform>().position.z), Quaternion.identity); 
                threshold -= 20;
                multiplicador++;
            }
    }
}
