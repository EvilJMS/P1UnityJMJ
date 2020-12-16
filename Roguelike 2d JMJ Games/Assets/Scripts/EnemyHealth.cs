using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth;

    public float currentHealth;
    
    void Start()
    {
        currentHealth = maxHealth;
    }
    

    public void LowHP(int damage){
        currentHealth -= damage;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
    }
}
