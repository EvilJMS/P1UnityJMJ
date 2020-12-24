using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
  public float lifetime;

  public int damage = 1;

    void Start()
    {
        StartCoroutine(DeathDelay());
    }


    void Update()
    {

    }
    IEnumerator DeathDelay(){
      yield return new WaitForSeconds(lifetime);
      Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

       if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyHealth>().LowHP(damage);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Wall"))
       {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Door"))
       {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
            collider.gameObject.GetComponent<EnemyHealth>().LowHP(damage);
            Destroy(gameObject);
        }

        if (collider.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

        if (collider.gameObject.CompareTag("Door"))
        {
            Destroy(gameObject);
        }
    }

}
