using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public Animator animator;
    public PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
      animator.SetBool("isOpen", false);
      player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other){
      if (other.CompareTag("Player")){
        animator.SetBool("isOpen", true);
        }
      }

      void OnTriggerExit2D(Collider2D other){
        if (other.CompareTag("Player")){
          animator.SetBool("isOpen", false);
          }
        }
}
