﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artorias : MonoBehaviour
{

    private Animator anim;
    private CharacterController controller;
    public Transform bulletPrefab;
    public float speed= 6.0f;
    public float turnSpeed = 60.0f;
    private Vector3 moveDirection = Vector3.zero;
    public float gravity = 20.0f;
    public GameObject untitled; //Artorias
    

    
    
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
        controller = GetComponent<CharacterController>();
    }

    

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey("w")){
            anim.SetInteger("AnimPar", 1);
        }else{
            anim.SetInteger("AnimPar", 0);
        }

         if(Input.GetKey("c")){
            anim.SetInteger("AnimRoll", 1);
        }else{
            anim.SetInteger("AnimRoll", 0);
        }

        if(Input.GetKey("p")){
            anim.SetInteger("AnimPointDown", 1);
        }else{
            anim.SetInteger("AnimPointDown", 0);
        }

        if(Input.GetKey("o")){
            anim.SetInteger("AnimPraiseTheSun", 1);
        }else{
            anim.SetInteger("AnimPraiseTheSun", 0);
        }

        if(Input.GetMouseButton(0)){
            anim.SetInteger("AnimSwordSlash", 1);
        }else{
            anim.SetInteger("AnimSwordSlash", 0);
        }

        if(Input.GetMouseButton(1)){
            anim.SetInteger("AnimSwordSlashString", 1);
        }else{
            anim.SetInteger("AnimSwordSlashString", 0);
        }

        if(controller.isGrounded){
            moveDirection = transform.forward * Input.GetAxis("Vertical")* speed; //controlling velocity and movement
        }

        float turn = Input.GetAxis("Horizontal");
        transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
        controller.Move(moveDirection * Time.deltaTime); //movement delay from controller
        moveDirection.y -= gravity * Time.deltaTime;
    }

     
}
