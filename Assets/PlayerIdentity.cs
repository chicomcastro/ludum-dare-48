using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdentity : MonoBehaviour
{
    public static PlayerIdentity instance;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else if (!GameObject.ReferenceEquals(this.gameObject, instance.gameObject)) {
            Destroy(this.gameObject);
        }
    }
}
