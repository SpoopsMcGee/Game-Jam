using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour {

    public GameObject currentInterObj = null;
	public string NameOfObject;
	private Inventory myInventory;
	public GameObject uiCanvas;
	private InteractionObject IGObject;
	void Start(){
		myInventory = this.gameObject.GetComponent<Inventory> ();

	}

    void Update() {

		DoInteraction (currentInterObj);
	}

	void DoInteraction(GameObject currentInterObj)

	{
		//allows the interaction to occur
		if (Input.GetButtonDown ("Interact") && currentInterObj) {


			print (IGObject.noun);
			print (IGObject.description);
			if (IGObject.GetComponent<AudioSource>()!= null) {
				IGObject.GetComponent<AudioSource>().Play();
			}

			if (NameOfObject == "Book") {
				// this happens on e press
				// myInventory.addObjectToInventory (currentInterObj);
				// currentInterObj = null;


			} else if (NameOfObject == "Paper") {
				GameObject.Destroy (currentInterObj);
				uiCanvas.transform.Find ("MorseTable").gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			}
		}





	}
	//allows the game to know what the character sees in front of them
	//will use data so other objects with the same tag aren't interacted with at same time
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("InterObj")) { 
			if (other.gameObject.GetComponent<InteractionObject> () != null) {
				NameOfObject = other.gameObject.GetComponent<InteractionObject> ().noun;
				Debug.Log(other.name);
				currentInterObj = other.gameObject;
				IGObject = currentInterObj.GetComponent<InteractionObject> ();
			}


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
