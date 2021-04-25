using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float damage = 10f;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag != "Player") {
            Enemy enemy = other.gameObject.GetComponent<Enemy>();
            if (enemy != null) {
                enemy.hp -= damage;
                this.enabled = false;
            }
        }
    }
}
