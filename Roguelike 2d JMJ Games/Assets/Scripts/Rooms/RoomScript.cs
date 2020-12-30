using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour
{
    public GameObject[] Enemies;
    public GameObject[] Doors;
    public bool Open;
    public bool firstTime;
    public bool allDead;
    public int numEnemies;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Open==false)
        {
            foreach (GameObject Door in Doors)
            {
                Door.GetComponent<DoorScript>().locked = true;
            }
        }
        else if (Open==true)
        {
           foreach (GameObject Door in Doors)
            {
                Door.GetComponent<DoorScript>().locked = false;
            }
        }
        if (numEnemies==0) {
          Open = true;
        } else{
          Open = false;
        }
    }

    public void CheckDeath(){
      if (numEnemies>0) {
        numEnemies--;
      }
    }

    public void addEnemy(){
      numEnemies++;
    }


    private void OnTriggerEnter2D(Collider2D other){
      if (other.CompareTag("Player")) {
        if (firstTime == false) {
          firstTime = true;
          Open = false;
        }
      }
    }


}
