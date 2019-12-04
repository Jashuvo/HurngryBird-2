using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public float enemyHealth = 4f;
    
    void OnCollisionEnter2D(Collision2D enemyCollsion)
    {

        if (enemyCollsion.relativeVelocity.magnitude > enemyHealth)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
;