using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
  public GameObject enemy;
  public GameObject Room;
  public GameObject boss;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Spawn(){
      if (Room.tag=="BossRoom") {
        GameObject newObject = Instantiate(boss, transform.position, Quaternion.identity) as GameObject;
        // newObject.GetComponent<EnemyHealth>().currentHealth = newObject.GetComponent<EnemyHealth>().maxHealth;
      } else{
        GameObject newObject = Instantiate(enemy, transform.position, Quaternion.identity) as GameObject;
        newObject.GetComponent<EnemyHealth>().currentHealth = newObject.GetComponent<EnemyHealth>().maxHealth;
        newObject.transform.parent = Room.transform;
        Room.GetComponent<RoomScript>().addEnemy();
      }
    }
}
