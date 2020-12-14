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

    
    void OnCollisionEnter2D(collision){
      if (collision.gameObject.CompareTag("Enemy"))
      {
          collision.gameObject.getComponent<EnemyHealth>().LowHP(damage);
      }
    }
}
