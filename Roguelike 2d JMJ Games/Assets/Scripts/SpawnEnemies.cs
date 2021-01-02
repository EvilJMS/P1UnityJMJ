using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
  public GameObject enemy;
  public GameObject Room;
    // Start is called before the first frame update
    void Start()
    {
      Room = transform.parent.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Spawn(){
      GameObject newObject = Instantiate(enemy, transform.position, Quaternion.identity) as GameObject;
      newObject.GetComponent<EnemyHealth>().currentHealth = newObject.GetComponent<EnemyHealth>().maxHealth;
      newObject.transform.parent = Room.transform;
      Room.GetComponent<RoomScript>().addEnemy();
    }
}
