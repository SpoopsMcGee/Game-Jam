using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionObject : MonoBehaviour {

	public GameObject currentInterObj = null;

    public string noun;
    public string description;

    public AudioSource source;
    

	public void Update()
	{
			
		DoInteraction (currentInterObj);
	}


	public void DoInteraction(GameObject currentInterObj)

    {
		
		if (Input.GetButtonDown ("Interact")) {
			

				print (noun);
				print (description);
			if (source) {
				source.Play (+1);
			} else {
			}
		}
    }
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("InterObj")) { 
			Debug.Log (other.name);
			currentInterObj = other.gameObject;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.CompareTag ("InterObj")) {   
			if (other.gameObject == currentInterObj) {
				currentInterObj = null;
			}


		}
	}
		
}
