using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour {

    public GameObject currentInterObj = null;
    

    void Update() {

		if (currentInterObj = "Book") {


		}


	}
	//allows the game to know what the character sees in front of them
	//will use data so other objects with the same tag aren't interacted with at same time
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
