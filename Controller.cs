using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed, Runspeed, rotationSpeed,backspeed;
    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Wait", true);
        //GetComponent<WallDestroy>().enabled = false;
    }
    void Update(){
        if (Input.GetKey("w") || Input.GetKey("up")){
            transform.position += transform.forward * speed;
            animator.SetBool("Run", true);
        }
        else if(Input.GetKey("s") || Input.GetKey("down")){
            transform.position -= transform.forward * backspeed;
            animator.SetBool("Walk", true);
        }
        else{
            animator.SetBool("Run", false);
            animator.SetBool("Walk", false);
        }

        if (Input.GetKey("a") || Input.GetKey("left")){
            transform.Rotate(0, -rotationSpeed, 0);
        }
        else if (Input.GetKey("d") || Input.GetKey("right")){
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey("space")){
            animator.SetBool("Jamp", true);
        }
        else{
            animator.SetBool("Jamp", false);
        }
    }
}
  
