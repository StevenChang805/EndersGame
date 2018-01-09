using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUFOController : MonoBehaviour {

		
	private float speed = 10;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {

		rb2d = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		rb2d.AddForce (movement * speed);

	}
	
		void moveUP()
		{
			float vertical = Input.GetAxis ("Vertical");
			Vector2 moveVertical = new Vector2 (0, moveVertical);
	
			rb2d.AddForce (moveVertical * speed);
		}

		void moveDOWN()
		{
			float vertical = Input.GetAxis ("Vertical");
			Vector2 moveVertical = new Vector2 (0, moveVertical);
		
			rb2d.AddForce (moveVertical * speed);
		}
	
		void moveLEFT()
		{
			float horizontal = Input.GetAxis ("Horizontal");
			Vector2 moveHorizontal = new Vector2 (moveHorizontal, 0);

			rb2d.AddForce (moveHorizontal * speed);
		}

		void moveRIGHT()
		{
			float horizontal = Input.GetAxis ("Horizontal");
			Vector2 moveHorizontal = new Vector2 (moveHorizontal, 0);
	
			rb2d.AddForce (moveHorizontal * speed);
		}
	}
