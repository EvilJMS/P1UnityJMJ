using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;
    public bool canMove=true;

    public GameObject bulletPrefab;
    public float BulletSpeed;
    private float lastFired;
    public float fireDelay;

    void Start(){
      moveSpeed = GlobalControl.Instance.moveSpeed;
      BulletSpeed = GlobalControl.Instance.BulletSpeed;
      fireDelay = GlobalControl.Instance.fireDelay;
    }


    // Update is called once per frame
    void Update()
    {
      if (canMove==true) {
        float shootHor = Input.GetAxisRaw("HorizontalShoot");
        float shootVer = Input.GetAxisRaw("VerticalShoot");

      movement.x = Input.GetAxisRaw("Horizontal");
      movement.y = Input.GetAxisRaw("Vertical");
      animator.SetFloat("Horizontal", movement.x);
      animator.SetFloat("Vertical", movement.y);
      animator.SetFloat("Speed", movement.sqrMagnitude);
      if ((shootHor!=0 || shootVer!=0)&& Time.time > lastFired + fireDelay) {
        Shoot(shootHor,shootVer);
        lastFired = Time.time;
      }
      }
    }
    void Shoot(float x, float y){
      GameObject bullet2 = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;
      bullet2.AddComponent<Rigidbody2D>().gravityScale = 0;
      bullet2.GetComponent<Rigidbody2D>().velocity = new Vector3(
      (x < 0) ? Mathf.Floor(x)* BulletSpeed : Mathf.Ceil(x) * BulletSpeed,
      (y < 0) ? Mathf.Floor(y)* BulletSpeed : Mathf.Ceil(y) * BulletSpeed,
      0
      );
    }


    void FixedUpdate()
    {
      rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void SaveData(){
      GlobalControl.Instance.moveSpeed = moveSpeed;
      GlobalControl.Instance.BulletSpeed = BulletSpeed;
      GlobalControl.Instance.fireDelay = fireDelay;
    }
}
