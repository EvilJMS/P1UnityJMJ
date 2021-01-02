using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
  public GameObject player;
  public bool TutorialFromMenu;
    // Start is called before the first frame update
    void Start()
    {
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
            SceneManager.LoadScene(2);
            break;
          case "GoBackToMenu":
            SceneManager.LoadScene(0);
            break;
          case "Level1":
            SceneManager.LoadScene(1);
            player.GetComponent<PlayerCurrency>().SaveData();
            player.GetComponent<PlayerMovement>().SaveData();
            player.GetComponent<HealthSystem>().SaveData();
            break;
          // case "GoToHub":

        }
      }
    }
}
