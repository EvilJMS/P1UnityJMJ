using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnEnemies : MonoBehaviour
{
  public GameObject[] enemy;
  public GameObject Room;
  public GameObject boss;
  private int rand;
    // Start is called before the first frame update
    void Start()
    {
      rand = Random.Range(0,4);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Spawn(){
      if (Room.tag=="BossRoom") {
        GameObject newObject = Instantiate(boss, transform.position, Quaternion.identity) as GameObject;
        newObject.GetComponent<EnemyHealth>().currentHealth = newObject.GetComponent<EnemyHealth>().maxHealth;
        newObject.transform.parent = Room.transform;
        Room.GetComponent<RoomScript>().addEnemy();
      } else if (SceneManager.GetActiveScene().name=="Tutorial") {
        GameObject newObject = Instantiate(enemy[0], transform.position, Quaternion.identity) as GameObject;
        newObject.GetComponent<EnemyHealth>().currentHealth = newObject.GetComponent<EnemyHealth>().maxHealth;
        newObject.transform.parent = Room.transform;
        Room.GetComponent<RoomScript>().addEnemy();
      }
       else{
        GameObject newObject = Instantiate(enemy[rand], transform.position, Quaternion.identity) as GameObject;
        newObject.GetComponent<EnemyHealth>().currentHealth = newObject.GetComponent<EnemyHealth>().maxHealth;
        newObject.transform.parent = Room.transform;
        Room.GetComponent<RoomScript>().addEnemy();
      }
    }
}
