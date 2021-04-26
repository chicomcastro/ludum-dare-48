using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ascending_debuff : MonoBehaviour
{
    public Vector2 direcao;
    string cena;
    public int contador_subida;

    private GameObject player;

    private void Start() {
        player = this.gameObject;
    }

    void Update()
    {
        direcao = player.GetComponent<PlatformerMotor2D>().velocity;
        if(detect_ascending())
        {
            contador_subida++;
            print(contador_subida);
            cena = SceneManager.GetSceneByName("Level0").name;
            if(cena  == null)
                player.GetComponent<sis_health>().maxhealth -= 0.01*(player.GetComponent<sis_defence>().defence);
            if(cena != null)
            {
                cena = null;
            }
            
        }
    }

    public bool detect_ascending()
    {
        if(direcao.y > 0)
        {
            return true;
        }
        else
            return false;
    }
}
