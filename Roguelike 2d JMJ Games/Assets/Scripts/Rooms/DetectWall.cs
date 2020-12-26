using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectWall : MonoBehaviour
{
  public GameObject door;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D c)
    {
      if (c.gameObject.CompareTag("Wall")) {
        door.GetComponent<DoorScript>().touchingWall = true;
      }
    }

    void OnTriggerEnter2D(Collider2D other) {
      if (other.CompareTag("Wall")) {
        door.GetComponent<DoorScript>().touchingWall = true;
      }
     }

     void OnCollisionStay2D(Collision2D c)
     {
       if (c.gameObject.CompareTag("Wall")) {
         door.GetComponent<DoorScript>().touchingWall = true;
       }
     }

     void OnTriggerStay2D(Collider2D other) {
       if (other.CompareTag("Wall")) {
         door.GetComponent<DoorScript>().touchingWall = true;
       }
      }
}
