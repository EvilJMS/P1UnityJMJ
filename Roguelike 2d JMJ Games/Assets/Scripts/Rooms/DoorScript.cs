using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Sprite Locked, Unlocked, wallDoor;
    public bool locked;
    public BoxCollider2D collider;
    public bool touchingWall;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (touchingWall==true) {
        GetComponent<SpriteRenderer>().sprite = wallDoor;
        collider.enabled = true;
      } else{
        if (locked==true)
        {
            GetComponent<SpriteRenderer>().sprite = Locked;
            collider.enabled = true;
            collider.isTrigger = false;
        }
        else if (locked==false)
        {
            GetComponent<SpriteRenderer>().sprite = Unlocked;
            collider.isTrigger = true;
        }
      }
    }


}
