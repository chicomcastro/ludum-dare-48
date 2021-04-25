using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private PlatformerMotor2D _motor;
    private bool shouldMove = false;
    private bool canTurn = true;
    private float lastTimeStopped = 0f;
    private Vector2 colliderWidth;
    private EnemyBoundaries eb;
    public float movement { get; private set; }
    private float originalSpeed;

    public float delayForTurn = 1f;
    public float maxTimeStopped = 5f;
    public float stoppingDelay = 5f;

    // Use this for initialization
    void Start()
    {
        eb = this.gameObject.GetComponent<EnemyBoundaries>();
        _motor = GetComponent<PlatformerMotor2D>();
        movement = -1;
        originalSpeed = _motor.groundSpeed;
        lastTimeStopped = Time.time;
        colliderWidth = this.gameObject.GetComponent<BoxCollider2D>().size;
        StartCoroutine(WaitForBoundaries());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!shouldMove) {
            return;
        }

        _motor.normalizedXMovement = movement;
        
        int layerMask = 1 << 3;
        Vector2 startPos = (Vector2) this.transform.position + (_motor.facingLeft ? 1 : -1) * Vector2.left * colliderWidth.x * 1.5f;
        RaycastHit2D hit = Physics2D.Raycast(startPos, -Vector2.up, Mathf.Infinity, layerMask);
        Debug.DrawRay(startPos, -Vector2.up * hit.distance);

        if (canTurn) {
            if (hit.point.y < this.transform.position.y - colliderWidth.y * 1.5f / 2) {
                StartCoroutine(DelayTurn());
                StartCoroutine(StayForAWhile(0.5f));
            }
        }

        if (Random.Range(0f, 1f) > 0.5f && Time.time - lastTimeStopped > stoppingDelay) {
            StartCoroutine(StayForAWhile());
        }
    }

    private IEnumerator WaitForBoundaries()
    {
        yield return new WaitUntil(() => eb.leftBoundaryPos != null && eb.rightBoundaryPos != null);
        shouldMove = true;
    }

    private IEnumerator DelayTurn()
    {
        movement *= -1;
        _motor.groundSpeed = Random.Range(originalSpeed / 2, originalSpeed);
        canTurn = false;
        yield return new WaitForSeconds(Random.Range(delayForTurn / 2, delayForTurn));
        canTurn = true;
    }

    private IEnumerator StayForAWhile(float waitTime = 0f)
    {
        shouldMove = false;
        if (waitTime == 0f) {
            waitTime = Random.Range(maxTimeStopped / 2, maxTimeStopped);
            movement *= Random.Range(0f, 1f) > 0.5f ? -1 : 1;
        }
        yield return new WaitForSeconds(waitTime);
        shouldMove = true;
        lastTimeStopped = Time.time;
    }
}
