using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
    private GameObject player;

    public int preco_maxhealth, preco_health, preco_defence, preco_speed, preco_attack;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void buy_maxhealth(int n)
    {
      if (player.GetComponent<sis_cash>().cash >= preco_maxhealth)
      {
        player.GetComponent<sis_health>().increase_maxhealth(n);
        player.GetComponent<sis_cash>().cash -= preco_maxhealth;
      }
    }
    public void buy_health(int n)
    {
      if (player.GetComponent<sis_cash>().cash >= preco_health)
      {
        player.GetComponent<sis_health>().increase_health(n);
        player.GetComponent<sis_cash>().cash -= preco_health;
      }
    }
    public void buy_defence()
    {
      if (player.GetComponent<sis_cash>().cash >= preco_defence)
      {
        player.GetComponent<sis_defence>().increase_defence();
        player.GetComponent<sis_cash>().cash -= preco_defence;
      }
    }
    public void buy_speed(int n) // 'n' eh percentual
    {
      if (player.GetComponent<sis_cash>().cash >= preco_speed)
      {
        player.GetComponent<sis_speed>().increase_speed(n);
        player.GetComponent<sis_cash>().cash -= preco_speed;
      }
    }
    public void buy_attack(int n) // 'n' eh percentual
    {
      if (player.GetComponent<sis_cash>().cash >= preco_attack)
      {
        player.GetComponent<sis_attack>().increase_attack(n);
        player.GetComponent<sis_cash>().cash -= preco_attack;
      }
    }

}
