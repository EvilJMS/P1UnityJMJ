using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDisparar : MonoBehaviour
{
    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject proyectil;
    private Transform player;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBtwShots = startTimeBtwShots;    
    }

    
    void Update()
    {
        if (timeBtwShots <= 0)
        {
            Instantiate(proyectil, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }else{
            timeBtwShots -= Time.deltaTime;
        }    
    }
}
