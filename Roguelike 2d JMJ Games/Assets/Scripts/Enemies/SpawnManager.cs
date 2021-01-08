using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  public List<GameObject> spawnList;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void turnOff(){
      foreach (GameObject x in spawnList) {
        x.GetComponent<EnemySpawner>().enemySpawn=true;
      }
    }
}
