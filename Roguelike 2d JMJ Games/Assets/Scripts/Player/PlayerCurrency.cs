using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCurrency : MonoBehaviour
{

    public int currentCurrency;
    public Text currencyText;

    void Start()
    {

        currentCurrency = GlobalControl.Instance.currentCurrency;
        DisplayMoney();
    }

    public void EarnMoney(int money)
    {
        currentCurrency += money;
        DisplayMoney();

    }

    void Update(){
      DisplayMoney();
    }

    public void SaveData(){
      GlobalControl.Instance.currentCurrency = currentCurrency;
    }

    public void DisplayMoney(){
      currencyText.text = currentCurrency + "";
    }
}
