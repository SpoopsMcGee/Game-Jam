using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {

    public GameObject currentInterObj = null;
    

    void Update()
    {
        if(Input.GetButtonDown ("Interact") && currentInterObj){
        //figure out what is and isn't an object get flavor text
        //or morse code

            currentInterObj.SendMessage("DoInteraction");
            
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("interObj")) {
            Debug.Log(other.name);
            currentInterObj = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("interObj"))
        {   
            if(other.gameObject == currentInterObj)
            {
                currentInterObj = null;
            }
            
            
        }
    }
}
