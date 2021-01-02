using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueNPC : MonoBehaviour
{
    public Dialogue dialogue;
    public bool endConversation;

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
          TriggerDialogue();
      }
    }
  }

    public void destroyNPC(){
      Destroy(this.gameObject);
    }
}
