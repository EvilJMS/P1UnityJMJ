using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
  public bool enemySpawn;
  public GameObject enemy;
  GameObject Room;
    // Start is called before the first frame update
    void Start()
    {
      Room = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other){
      if (other.CompareTag("Player")) {
        if (enemySpawn == false) {
          GameObject newObject = Instantiate(enemy, transform.position, Quaternion.identity) as GameObject;
          newObject.GetComponent<EnemyHealth>().currentHealth = newObject.GetComponent<EnemyHealth>().maxHealth;
          newObject.transform.parent = Room.transform;
          Room.GetComponent<RoomScript>().addEnemy();
          enemySpawn=true;
        }
      }
    }
}
