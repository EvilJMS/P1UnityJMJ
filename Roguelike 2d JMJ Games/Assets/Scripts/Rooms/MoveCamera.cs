using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
  public bool on;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other){
      if (on==true) {
        if(other.CompareTag("Player")){
          switch (gameObject.tag)
      {
          case "LeftDoor":
              Camera.main.transform.Translate(-16, 0, -10);
              break;
          case "RightDoor":
              Camera.main.transform.Translate(16, 0, -10);
              break;
          case "UpDoor":
              Camera.main.transform.Translate(0, 16, -10);
              break;
          case "DownDoor":
              Camera.main.transform.Translate(0, -16, -10);
              break;
          default:
              break;
      }
          on=false;
    		}
      }
      
  	}
}
