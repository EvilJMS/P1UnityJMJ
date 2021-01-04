using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth;

    public float currentHealth;

    public GameObject lootDrop;

    GameObject Room;

    void Start()
    {
        Room = transform.parent.gameObject;
        currentHealth = maxHealth;
    }


    public void LowHP(int damage){
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
          Destroy(gameObject);
          Instantiate(lootDrop, transform.position, Quaternion.identity);
          Room.GetComponent<RoomScript>().CheckDeath();
        }
    }
}
