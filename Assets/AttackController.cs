using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    private Animator animator;
    private PC2D.PlatformerAnimation2D plataformerAnimation;
    private PlatformerMotor2D plataformerMotor;
    private bool isAttacking = false;
    private Vector2 originalVelocity;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponentInChildren<Animator>();
        plataformerAnimation = this.gameObject.GetComponent<PC2D.PlatformerAnimation2D>();
        plataformerMotor = this.gameObject.GetComponent<PlatformerMotor2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && !isAttacking) {
            Attack();
        }
        if(isAttacking && plataformerMotor.IsOnGround()) {
            plataformerMotor.velocity = new Vector2(0, plataformerMotor.velocity.y);
        }
    }

    void Attack() {
        isAttacking = true;
        plataformerAnimation.enabled = false;
        animator.Play("_attack");
        StartCoroutine(ExecuteWithDelay(0.75f));
    }

    IEnumerator ExecuteWithDelay(float delay) {
        yield return new WaitForSeconds(delay);
        plataformerAnimation.enabled = true;
        isAttacking = false;
    }
}
