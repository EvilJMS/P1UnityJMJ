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
        damage = GlobalControl.Instance.damage;
    }


    void Update()
    {

    }
    IEnumerator DeathDelay(){
      yield return new WaitForSeconds(lifetime);
      Destroy(gameObject);
    }



    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
            collider.gameObject.GetComponent<EnemyHealth>().LowHP(damage);
            Destroy(gameObject);
        }

        if (collider.gameObject.CompareTag("Wall")||collider.gameObject.CompareTag("Door"))
        {
            Destroy(gameObject);
        }


    }

    public void SaveData(){
      GlobalControl.Instance.damage = damage;
    }

}
