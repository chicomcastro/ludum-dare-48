using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttack : AttackController {

    public GameObject arrow;
    public Transform attackSpot;

    public override void ExecuteAttack()
    {
        base.ExecuteAttack();
        print("Ataque ranged");
        GameObject gamo = Instantiate(arrow, attackSpot.transform.position, arrow.transform.rotation);
        gamo.GetComponent<Mover>().speed *= plataformerMotor.facingLeft ? -1 : 1;
        gamo.transform.localScale = new Vector3(
            gamo.transform.localScale.x,
            gamo.transform.localScale.y * (plataformerMotor.facingLeft ? -1 : 1),
            gamo.transform.localScale.z
        );
    }
}
