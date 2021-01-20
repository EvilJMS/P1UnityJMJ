using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxHealth : MonoBehaviour
{
    public float maxHealth;

    public float currentHealth;

    public GameObject lootDrop;

    public GameObject player;

    public Sprite Good, Broken;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LowHP(int damage){
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<SpriteRenderer>().sprite = Broken;
            Instantiate(lootDrop, transform.position, Quaternion.identity);
            
        } else
        {
            GetComponent<BoxCollider2D>().enabled = true;
            GetComponent<SpriteRenderer>().sprite = Good;
        }
    }
}
