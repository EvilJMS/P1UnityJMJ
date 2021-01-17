using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueNPC : MonoBehaviour
{
    public Dialogue dialogue;
    public bool endConversation;

    void Start(){
      if (SceneManager.GetActiveScene().name=="Hub"){
        endConversation=GlobalControl.Instance.hubEntered;
      }
    }

    public void TriggerDialogue(){
      FindObjectOfType<DialogManager>().StartDialogue(dialogue);
    }

    void OnTriggerEnter2D(Collider2D other){
      if (other.CompareTag("Player")){
        if (this.CompareTag("Spawner")) {
          FindObjectOfType<DialogManager>().isSpawner=true;
        }
        if (endConversation==false) {
          endConversation=true;
          if (SceneManager.GetActiveScene().name=="Hub"){
            GlobalControl.Instance.hubEntered=endConversation;
          }
          TriggerDialogue();
      }
    }
  }

    public void destroyNPC(){
      Destroy(this.gameObject);
    }
}
