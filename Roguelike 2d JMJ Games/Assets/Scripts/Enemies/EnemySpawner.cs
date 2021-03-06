﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
  public bool enemySpawn;
  public GameObject[] spawner;
  public GameObject manager;
  private int rand;
  public GameObject Room;
    // Start is called before the first frame update
    void Start()
    {
      manager=this.transform.parent.gameObject;
      rand = Random.Range(0,4);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other){
      if (other.CompareTag("Player")) {
        if (enemySpawn == false) {
          if (Room.tag=="BossRoom") {
            spawner[0].GetComponent<SpawnEnemies>().Spawn();
          } else{
            if (rand==0) {
              spawner[0].GetComponent<SpawnEnemies>().Spawn();
            } else{
              for (int i = 0; i<rand; i++) {
                spawner[i].GetComponent<SpawnEnemies>().Spawn();
              }
            }
          }
          if (this.transform.parent.CompareTag("SpawnManager")) {
            manager.GetComponent<SpawnManager>().turnOff();
          } else{

          }
          enemySpawn=true;
        }
      }
    }
}
