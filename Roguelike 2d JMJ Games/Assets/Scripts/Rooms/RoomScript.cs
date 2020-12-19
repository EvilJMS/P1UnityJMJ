using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour
{
    public GameObject[] Enemies;
    public GameObject[] Doors;
    public bool Open;
    public bool openDoors;
    public bool firstTime;
    public bool allDead;

    
    
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

        for (int i = 0; i < Enemies.Length; i++)
        {
            if (Enemies[i]!=null)
            {
                allDead=false;
            
            } else
            {
                allDead=true;
            }
        }
        if (allDead)
        {
            Open = true;
        }
    }

    
    private void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player"))
        {
            if (firstTime == false)
            {
                firstTime = true;
                Open = false;
            }
        }
    }

    
}
