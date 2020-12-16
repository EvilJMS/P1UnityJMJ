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
        }
    }

}
