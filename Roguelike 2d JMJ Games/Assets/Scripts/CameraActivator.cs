using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraActivator : MonoBehaviour
{
    public GameObject[] cameras;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other){
      if (other.CompareTag("Player")) {
        foreach (GameObject camera in cameras)
        {
            if (camera.GetComponent<MoveCamera>().on == false) {
              camera.GetComponent<MoveCamera>().on = true;
            }
        }
      }
    }
}
