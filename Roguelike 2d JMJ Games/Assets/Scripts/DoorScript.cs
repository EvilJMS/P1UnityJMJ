using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Sprite Locked, Unlocked;
    public bool locked;
    public BoxCollider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (locked==true)
        {
            GetComponent<SpriteRenderer>().sprite = Locked;
            collider.enabled = true;
        }
        else if (locked==false)
        {
            GetComponent<SpriteRenderer>().sprite = Unlocked;
            collider.enabled = false;
        }
        
    }
}
