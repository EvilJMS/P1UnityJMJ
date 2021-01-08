using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
  public GameObject player;
  public GameObject[] skillList;
  public bool TutorialFromMenu;
    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.FindGameObjectWithTag("Player");
      TutorialFromMenu = GlobalControl.Instance.TutorialFromMenu;
      if (TutorialFromMenu==true) {
        this.tag="GoBackToMenu";
        GlobalControl.Instance.TutorialFromMenu=false;
      }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other){
      if (other.CompareTag("Player")){
        switch(this.tag){
          case "EnterTutorial":
          foreach (GameObject skill in skillList) {
            skill.GetComponent<Skill>().SaveData();
          }
            player.GetComponent<PlayerCurrency>().SaveData();
            player.GetComponent<PlayerMovement>().SaveData();
            player.GetComponent<HealthSystem>().SaveData();
            SceneManager.LoadScene(2);
            break;
          case "GoBackToMenu":
            SceneManager.LoadScene(0);
            break;
          case "Level1":
            foreach (GameObject skill in skillList) {
              skill.GetComponent<Skill>().SaveData();
            }
            player.GetComponent<PlayerCurrency>().SaveData();
            player.GetComponent<PlayerMovement>().SaveData();
            player.GetComponent<HealthSystem>().SaveData();
            SceneManager.LoadScene(1);
            break;
          case "Level2":
            player.GetComponent<PlayerCurrency>().SaveData();
            player.GetComponent<PlayerMovement>().SaveData();
            player.GetComponent<HealthSystem>().SaveData();
            SceneManager.LoadScene(5);
            break;
          case "Level3":
            player.GetComponent<PlayerCurrency>().SaveData();
            player.GetComponent<PlayerMovement>().SaveData();
            player.GetComponent<HealthSystem>().SaveData();
            SceneManager.LoadScene(6);
            break;
          case "WinScreen":
            player.GetComponent<PlayerCurrency>().SaveData();
            player.GetComponent<PlayerMovement>().SaveData();
            SceneManager.LoadScene(7);
            break;
          case "GoToHub":
            player.GetComponent<PlayerMovement>().SaveData();
            SceneManager.LoadScene(3);
            break;
        }
      }
    }
}
