using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sis_cash : MonoBehaviour
{
    public int cash = 0; // eh isso

    public Text dinheiro;

    public void Start()
    {
        if (dinheiro == null) {
            GameObject dinheiroObj = GameObject.FindGameObjectWithTag("Moeda");
            if (dinheiroObj != null) {
                dinheiro = dinheiroObj.GetComponent<Text>();
            }
        }
        else {
            dinheiro.GetComponent<Text>().text = cash.ToString();
        }
    }

    public void increasecash()
    {
        cash += 100;
        dinheiro.GetComponent<Text>().text = cash.ToString();
    }
}
