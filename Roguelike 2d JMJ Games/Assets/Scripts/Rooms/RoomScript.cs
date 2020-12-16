using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour
{
    public GameObject[] Doors;
    public bool Open;
    public bool openDoors;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        openDoors = Doors[0].GetComponent<DoorScript>().locked;

        if (Open==false&&openDoors==true)
        {
            foreach (GameObject Door in Doors)
            {
                Door.GetComponent<DoorScript>().locked = true;
            }
        }
        else if (Open==true&&openDoors==false)
        {
           foreach (GameObject Door in Doors)
            {
                Door.GetComponent<DoorScript>().locked = false;
            } 
        }
    }

    
}
