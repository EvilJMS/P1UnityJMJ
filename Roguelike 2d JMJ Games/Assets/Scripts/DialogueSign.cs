using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSign : MonoBehaviour
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

  public void destroyNPC(){
    Destroy(this.gameObject);
  }
}
