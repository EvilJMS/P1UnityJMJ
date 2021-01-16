using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{

    public static GlobalControl Instance;
    public int HP;
    public int numCorazones;
    public float moveSpeed;
    public float BulletSpeed;
    public float fireDelay;
    public int currentCurrency;
    public bool TutorialFromMenu;
    public bool hubEntered;
    public int damage;
    public List<int> counterList;
    public List<int> priceList;
    void Awake ()
       {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy (gameObject);
        }
      }

}
