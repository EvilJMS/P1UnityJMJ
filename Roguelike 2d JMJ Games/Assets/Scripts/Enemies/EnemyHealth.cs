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
        player = GameObject.FindGameObjectWithTag("Player");
        if (this.tag=="Boss") {
          if (SceneManager.GetActiveScene().name=="NIvel1") {
            maxHealth = 10;
          } else if (SceneManager.GetActiveScene().name=="Nivel2") {
            maxHealth = 15;
          } else if (SceneManager.GetActiveScene().name=="Nivel3") {
            maxHealth = 20;
          }
        }
        currentHealth = maxHealth;
    }


    public void LowHP(int damage){
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
          if (this.tag=="Boss") {
            GameObject newObject = Instantiate(changeScene, transform.position, Quaternion.identity) as GameObject;
            if (SceneManager.GetActiveScene().name=="NIvel1") {
              newObject.transform.tag="Level2";
            } else if (SceneManager.GetActiveScene().name=="Nivel2") {
              newObject.transform.tag="Level3";
            } else if (SceneManager.GetActiveScene().name=="Nivel3") {
              newObject.transform.tag="WinScreen";
            }
            player.GetComponent<PlayerCurrency>().EarnMoney(50);
            Destroy(gameObject);

          } else{
            Destroy(gameObject);
            Instantiate(lootDrop[Random.Range(0,2)], transform.position, Quaternion.identity);
            Room.GetComponent<RoomScript>().CheckDeath();
          }
        }
    }
}
