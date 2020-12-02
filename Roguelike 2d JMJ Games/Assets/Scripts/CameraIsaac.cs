using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraIsaac : MonoBehaviour
{
    public GameObject CurrentRoom;
    private Vector3 ref1;

    public float smoothness;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position!=new Vector3(CurrentRoom.transform.x,CurrentRoom.transform.y,-10)){
           transform.position = Vector3.SmoothDamp(transform.position, CurrentRoom.transform.position, ref ref1, smoothness); 
        }
    }
}
