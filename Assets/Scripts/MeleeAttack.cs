using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : AttackController {
    public override void ExecuteAttack()
    {
        base.ExecuteAttack();
        print("Ataque melle");
    }
}
