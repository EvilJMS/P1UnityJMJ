using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
  public bool enemySpawn;
  public GameObject spawner;
  public GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
      manager=this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other){
      if (other.CompareTag("Player")) {
        if (enemySpawn == false) {
          spawner.GetComponent<SpawnEnemies>().Spawn();
          if (this.transform.parent.CompareTag("SpawnManager")) {
            manager.GetComponent<SpawnManager>().turnOff();
          } else{

          }
          enemySpawn=true;
        }
      }
    }
}
