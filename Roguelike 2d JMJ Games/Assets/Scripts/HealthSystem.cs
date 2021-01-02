using System.Collections;
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
            vida = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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

    
}
