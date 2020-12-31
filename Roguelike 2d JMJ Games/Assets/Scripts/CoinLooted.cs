using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLooted : MonoBehaviour
{
    public int coinValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerCurrency>().EarnMoney(coinValue);
            Destroy(gameObject);
        }
    }
}
