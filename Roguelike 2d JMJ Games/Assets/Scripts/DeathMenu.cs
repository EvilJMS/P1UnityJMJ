using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public void Retry(){
      SceneManager.LoadScene(1);
    }

    public void GoToHub(){
      SceneManager.LoadScene(3);
    }
}
