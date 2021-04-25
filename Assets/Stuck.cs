using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stuck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag != "Player" && other.tag != "Arrow") {
            this.transform.SetParent(other.transform);
            this.gameObject.GetComponent<Mover>().speed = 0;
        }
    }
}
