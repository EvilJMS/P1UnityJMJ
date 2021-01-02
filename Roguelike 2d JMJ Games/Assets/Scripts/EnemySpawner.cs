using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
  public bool enemySpawn;
  public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other){
      if (other.CompareTag("Player")) {
        if (enemySpawn == false) {
          spawner.GetComponent<SpawnEnemies>().Spawn();
          enemySpawn=true;
        }
      }
    }
}
