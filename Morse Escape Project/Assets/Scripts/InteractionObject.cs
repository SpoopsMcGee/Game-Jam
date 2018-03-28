using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour {

    public string noun;
    public string description;

    public AudioSource source;
    public bool visible = true;


        public InteractionObject() { 

        if (visible == false)
        {
          
        }
        }

public void DoInteraction()

    {
        if (source) {

            print(description);
            source.Play(+1);
        }
        else
            {
        }

    }
}
