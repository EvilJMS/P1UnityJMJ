using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float lifetime;
  
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeathDelay());
    }


    IEnumerator DeathDelay(){
      yield return new WaitForSeconds(lifetime);
      Destroy(gameObject);
    }

    
    void OnCollisionEnter2D(Collision2D collision){
      if (collision.CompareTag("Enemy"))
      {
          collision.getComponent<EnemyHealth>().LowHP(damage);
      }
    }
}
