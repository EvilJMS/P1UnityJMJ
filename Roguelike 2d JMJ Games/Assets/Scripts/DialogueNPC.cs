using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueNPC : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue(){
      FindObjectOfType<DialogManager>().StartDialogue(dialogue);
    }

    void OnTriggerEnter2D(Collider2D other){
      if (other.CompareTag("Player")){
        TriggerDialogue();
      }
    }

    void destroyNPC(){
      Destroy(this.gameObject);
    }
}
