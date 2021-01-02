﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogManager : MonoBehaviour
{
    public Text nametext;
    public Text dialogueText;
    private Queue<string> sentences;
    public SpawnEnemies spawn;
    public bool isSpawner;
    public DialogueNPC npc;
    public PlayerMovement player;


    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
      sentences = new Queue<string>();
      player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    public void StartDialogue(Dialogue dialogue){
      player.canMove=false;
      animator.SetBool("isOpen", true);
      nametext.text = dialogue.name;
      sentences.Clear();

      foreach(string sentence in dialogue.sentences){
        sentences.Enqueue(sentence);
      }

      DisplayNextSentence();
    }

    public void DisplayNextSentence(){
      if (sentences.Count==0) {
        EndDialogue();
        return;
      }

      string sentence = sentences.Dequeue();
      dialogueText.text = sentence;
      }

    void EndDialogue(){
      animator.SetBool("isOpen", false);
      player.canMove=true;
      if (isSpawner==true) {
        spawn.Spawn();
        isSpawner=false;
        npc.destroyNPC();
      }
    }

}
