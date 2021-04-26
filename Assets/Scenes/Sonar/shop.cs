using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
    private GameObject player;

    public int preco_maxhealth, preco_health, preco_defence;

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
        GetComponent<sis_cash>().cash -= 1000;
      }
    }
    public void buy_defence()
    {
      if (GetComponent<sis_cash>().cash >= preco_defence)
      {
        GetComponent<sis_defence>().increase_defense();
        GetComponent<sis_cash>().cash -= 2000;
      }
    }

}
