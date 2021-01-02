using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCurrency : MonoBehaviour
{

    public int currentCurrency;

    void Start()
    {
        
        currentCurrency = GlobalControl.Instance.currentCurrency;
    }

    public void EarnMoney(int money)
    {
        currentCurrency += money;
    }

    public void SaveData(){
      GlobalControl.Instance.currentCurrency = currentCurrency;
    }
}
