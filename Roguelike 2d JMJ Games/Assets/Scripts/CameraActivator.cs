using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraActivator : MonoBehaviour
{
    public GameObject[] cameras;
    bool on;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        on = cameras[0].GetComponent<MoveCamera>().on;
        if (on == false)
        {
            foreach (GameObject camera in cameras)
            {
                camera.GetComponent<MoveCamera>().on = true;
            }
        }
    }
}
