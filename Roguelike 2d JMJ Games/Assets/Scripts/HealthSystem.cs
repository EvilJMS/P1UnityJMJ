﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public int vida;
    public int numCorazones;
    public Image[] corazones;
    public Sprite corazonCompleto;
    public Sprite corazonVacio;

    private void Start()
    {
        vida = GlobalControl.Instance.HP;
        numCorazones = GlobalControl.Instance.numCorazones;
        DibujarCorazones();
    }

    void Update()
    {

    }

    public void TakeDamage(int damage)
    {
        vida -= damage;
        if (vida <= 0)
        {
            // vida = 0;
            ResetData();
            GetComponent<PlayerCurrency>().SaveData();
            GetComponent<PlayerMovement>().SaveData();
            SceneManager.LoadScene(4);
        }
        DibujarCorazones();
    }

    void DibujarCorazones()
    {
        if (vida > numCorazones)
        {
            vida = numCorazones;
        }

        for (int i = 0; i < corazones.Length; i++)
        {
            if (i < vida)
            {
                corazones[i].sprite = corazonCompleto;
            }
            else
            {
                corazones[i].sprite = corazonVacio;
            }

            if (i < numCorazones)
            {
                corazones[i].enabled = true;
            }
            else
            {
                corazones[i].enabled = false;
            }
        }
    }

    public void EarnHealth(int heart)
    {
          if (vida!=numCorazones) {
            vida+=heart;
          }
          DibujarCorazones();
    }

    public void SaveData(){
      GlobalControl.Instance.HP = vida;
      GlobalControl.Instance.numCorazones = numCorazones;
    }

    void ResetData(){
      GlobalControl.Instance.numCorazones = numCorazones;
      GlobalControl.Instance.HP = numCorazones;
    }


}
