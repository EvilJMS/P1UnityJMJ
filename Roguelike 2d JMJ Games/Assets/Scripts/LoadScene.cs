using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other){
      if (other.CompareTag("Player")){
        switch(this.tag){
          case "EnterTutorial":
            Time.timeScale = 1f;
            SceneManager.LoadScene(2);
            break;
          case "GoBackToMenu":
            Time.timeScale = 1f;
            SceneManager.LoadScene(0);
            break;
          case "Level1":
            Time.timeScale = 1f;
            SceneManager.LoadScene(1);
            break;
        }
      }
    }
}
