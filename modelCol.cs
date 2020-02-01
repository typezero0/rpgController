using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelCol : MonoBehaviour
{

    private Animator anim;
   
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>(); //instantiating an Animator object
    }

    void OnTriggerEnter(Collider other){  //OnTriggerEnter includes collision with  Body too, not just Sword
        if(other.name != "Terrain"){//ignoring Terrain collision   
            anim.SetInteger("AnimDeath", 1);
            Debug.Log("Collision Detected!");
            //GetComponent<Collider>().enabled = false;
        }
            
    }
       
}
