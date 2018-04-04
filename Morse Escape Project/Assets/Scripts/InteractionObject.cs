using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionObject : MonoBehaviour {

	public GameObject currentInterObj = null;

    public string noun;
    public string description;

    public AudioSource source;
    
	//allows player to interact with object currently in front of them
	public void Update()
	{
			
		DoInteraction (currentInterObj);
	}


	public void DoInteraction(GameObject currentInterObj)

    {
		//allows the interaction to occur
		if (Input.GetButtonDown ("Interact") && currentInterObj) {
			

				print (this.noun);
				print (this.description);
			if (source) {
				source.Play (+1);
			}
		}
    }
	//check to make sure what object is in front of them
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Player")) { 
			Debug.Log (other.name);
			currentInterObj = other.gameObject;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.CompareTag ("Player")) {   
			if (other.gameObject == currentInterObj) {
				currentInterObj = null;
			}


		}
	}
		
}
