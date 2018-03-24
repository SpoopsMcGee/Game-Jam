﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {

    public GameObject currentInterObj = null;


    void Update() {
        if (Input.GetButtonDown("Interact") && currentInterObj) {
            //figure out what is and isn't an object get flavor text
            //or morse code

            Debug.Log("you found this");
            //play sound after text is shown
            if (currentInterObj)
                {
                currentInterObj.GetComponent<AudioSource>().Play();
               
            }

        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("InterObj")) { 
        Debug.Log(other.name);
        currentInterObj = other.gameObject;

            //returns name of object

    }

    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("InterObj"))
        {   
            if(other.gameObject == currentInterObj) 
            {
                currentInterObj = null;
            }
            
            
        }
    }


    
}
