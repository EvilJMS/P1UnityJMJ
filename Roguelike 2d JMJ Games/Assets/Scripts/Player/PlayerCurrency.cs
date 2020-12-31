using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCurrency : MonoBehaviour
{
    int initialCurrency = 0;
    public int currentCurrency;

    void Start()
    {
        currentCurrency = initialCurrency;
    }

    public void EarnMoney(int money)
    {
        currentCurrency += money;
    }
}
