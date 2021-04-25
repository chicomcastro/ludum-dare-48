using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoundaries : MonoBehaviour
{
    public Vector2 leftBoundaryPos;
    public Vector2 rightBoundaryPos;
    private float currentDistance = 0f;
    private int layerMask;

    // Start is called before the first frame update
    void Start()
    {
        layerMask = 1 << 3;
        Vector2 startPos = this.transform.position;
        RaycastHit2D hit = Physics2D.Raycast(startPos, -Vector2.up, Mathf.Infinity, layerMask);
        currentDistance = hit.distance;
        leftBoundaryPos = SearchBoundary(Vector2.left);
        rightBoundaryPos = SearchBoundary(Vector2.right);
    }
    
    Vector2 SearchBoundary(Vector2 direction) {
        bool haveFound = false;
        Vector2 startPos = this.transform.position;
        Vector2 foundPos = Vector2.zero;

        while (!haveFound) {
            // Cast a ray straight down.
            RaycastHit2D hit = Physics2D.Raycast(startPos, -Vector2.up, Mathf.Infinity, layerMask);

            // If it hits something...
            if (hit.collider != null)
            {
                // Debug.Log("Hit");
            }
            else {
                // Debug.Log("Don't hit"); 
                continue;
            }

            if (Mathf.Abs(hit.distance - currentDistance) > 0.1f) {
                haveFound = true;
                foundPos = hit.point;   
            }
            
            startPos += direction * Time.fixedDeltaTime;
        }

        return foundPos;
    }
}
