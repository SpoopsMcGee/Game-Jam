using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;


public class Player_Control : MonoBehaviour
{


    public float speed = 0.04f;
    private Rigidbody2D rb;

    Animator anim;      // Jess added, testing anim for movement

    // Use this for initialization


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();    // Jess added, testing anim for movement
        
    }

    void Update()
    {
        Movement();  // Jess added, new void area
    }

    void Movement()
	{
		anim.SetFloat ("speed", Mathf.Abs (Input.GetAxis ("Horizontal")));

		anim.SetFloat ("speed", Mathf.Abs (Input.GetAxis ("Vertical")));



		if (Input.GetAxisRaw ("Horizontal") > 0) {
			transform.Translate (Vector3.right * speed * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 0);
			if (Input.GetAxisRaw ("Vertical") == 0) {
				anim.Play ("Char_Walk_Side");
				this.GetComponent<SpriteRenderer> ().flipX = false;
			}
				
		} else if (Input.GetAxisRaw ("Horizontal") < 0) {
			transform.Translate (Vector3.left * speed * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 0);
			if (Input.GetAxisRaw ("Vertical") == 0) {
				anim.Play ("Char_Walk_Side");
				this.GetComponent<SpriteRenderer> ().flipX = true;
			}
				
		}

		if (Input.GetAxisRaw ("Vertical") > 0) {
			transform.Translate (Vector3.up * speed * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 0);
			anim.Play ("Char_Walk_Up");
		} else if (Input.GetAxisRaw ("Vertical") < 0) {
			transform.Translate (Vector3.down * speed * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 0);
			anim.Play ("Char_Walk_Down");

		}

		if (Input.GetAxisRaw ("Vertical") == 0 && Input.GetAxisRaw ("Horizontal") == 0) { //added idle anim for keys, still need to flip anim for KeyCode.A
			if (Input.GetKeyUp (KeyCode.S) || Input.GetKeyUp (KeyCode.DownArrow)) {
				anim.Play ("Char_Idle");
			} else if (Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.UpArrow)) {
				anim.Play ("Char_Idle_Up");
			} else if (Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp (KeyCode.RightArrow)) {
				anim.Play ("Char_Idle_Side");
			} else if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.LeftArrow)) {
				anim.Play ("Char_Idle_Side");
				this.GetComponent<SpriteRenderer> ().flipX = true;
			}
		}


	}
}