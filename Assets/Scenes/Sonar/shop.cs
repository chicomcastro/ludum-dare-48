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
      if (GetComponent<sis_cash>().cash >= preco_maxhealth)
      {
        GetComponent<sis_health>().increase_maxhealth(n);
        GetComponent<sis_cash>().cash -= preco_maxhealth;
      }
    }
    public void buy_health(int n)
    {
      if (GetComponent<sis_cash>().cash >= preco_health)
      {
        GetComponent<sis_health>().increase_health(n);
        GetComponent<sis_cash>().cash -= preco_health;
      }
    }
    public void buy_defence()
    {
      if (GetComponent<sis_cash>().cash >= preco_defence)
      {
        GetComponent<sis_defence>().increase_defence();
        GetComponent<sis_cash>().cash -= preco_defence;
      }
    }
    public void buy_speed(int n) // 'n' eh percentual
    {
      if (GetComponent<sis_cash>().cash >= preco_speed)
      {
        GetComponent<sis_speed>().increase_speed(n);
        GetComponent<sis_cash>().cash -= preco_speed;
      }
    }
    public void buy_attack(int n) // 'n' eh percentual
    {
      if (GetComponent<sis_cash>().cash >= preco_attack)
      {
        GetComponent<sis_attack>().increase_attack(n);
        GetComponent<sis_cash>().cash -= preco_attack;
      }
    }

}
