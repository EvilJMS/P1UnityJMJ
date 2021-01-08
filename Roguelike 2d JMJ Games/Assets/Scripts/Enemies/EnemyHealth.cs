using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth;

    public float currentHealth;

    public GameObject[] lootDrop;

    public GameObject changeScene;
    public GameObject player;

    GameObject Room;

    void Start()
    {
        Room = transform.parent.gameObject;
        currentHealth = maxHealth;
        player = GameObject.FindGameObjectWithTag("Player");
    }


    public void LowHP(int damage){
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
          if (this.tag=="Boss") {
            Destroy(gameObject);
            GameObject newObject = Instantiate(changeScene, transform.position, Quaternion.identity) as GameObject;
            if (SceneManager.GetActiveScene().name=="NIvel1") {
              newObject.tag="Level2";
            } else if (SceneManager.GetActiveScene().name=="Nivel2") {
              newObject.tag="Level3";
            }
            player.GetComponent<PlayerCurrency>().EarnMoney(50);

          } else{
            Destroy(gameObject);
            Instantiate(lootDrop[Random.Range(0,2)], transform.position, Quaternion.identity);
            Room.GetComponent<RoomScript>().CheckDeath();
          }
        }
    }
}
