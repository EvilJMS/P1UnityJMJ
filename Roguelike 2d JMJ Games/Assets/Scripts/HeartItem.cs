using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartItem : MonoBehaviour
{
    public int heartValue;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<HealthSystem>().vida!=collision.gameObject.GetComponent<HealthSystem>().numCorazones) {
              collision.gameObject.GetComponent<HealthSystem>().EarnHealth(heartValue);
              Destroy(gameObject);
            }
        }
    }
}
