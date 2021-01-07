using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public Sprite[] Locked, Unlocked, wallDoor;
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
        GetComponent<SpriteRenderer>().sprite = wallDoor[GetIdScene()];
        collider.enabled = true;
      } else{
        if (locked==true)
        {
            GetComponent<SpriteRenderer>().sprite = Locked[GetIdScene()];
            collider.enabled = true;
            collider.isTrigger = false;
        }
        else if (locked==false)
        {
            GetComponent<SpriteRenderer>().sprite = Unlocked[GetIdScene()];
            collider.isTrigger = true;
        }
      }
    }

    int GetIdScene(){
      switch (SceneManager.GetActiveScene().name){
        case "NIvel1":
          return 0;
        case "Nivel2":
          return 1;
        case "Nivel3":
          return 2;
        case "Tutorial":
          return 0;
        default:
          return 0;
      }
    }


}
