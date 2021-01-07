using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectWall : MonoBehaviour
{
  public GameObject door;
  public GameObject room;
    // Start is called before the first frame update
    void Start()
    {
      room = transform.parent.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }






     void OnTriggerEnter2D(Collider2D other) {
       if (other.CompareTag("Wall")||other.CompareTag("ClosedWall")) {
         door.GetComponent<DoorScript>().touchingWall = true;
         Debug.Log(door.tag);
       }
      }
}
