using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementProyectil : MonoBehaviour
{
    public float speed;
    public int damage;

    private Transform player;
    private Vector2 target;
    private Rigidbody2D proyectilRB; 
    
    void Start()
    {
        proyectilRB = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = (player.transform.position - transform.position).normalized * speed;
        proyectilRB.velocity = new Vector2(target.x, target.y);
    }

   

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Wall") || collider.gameObject.CompareTag("Door"))
        {
            Destroy(gameObject);
        }
        if (collider.gameObject.CompareTag("Player"))
        {
            collider.gameObject.GetComponent<HealthSystem>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }

    public void SaveData()
    {
        GlobalControl.Instance.damage = damage;
    }
}
