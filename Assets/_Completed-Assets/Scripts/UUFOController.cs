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
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow))
		{
			moveUP();
			moveDOWN().enabled = false;
			moveLEFT().enabled = false;
			moveRIGHT().enabled = false;
		}
		
		if (Input.GetKeyDown (KeyCode.DownArrow))
		{
			moveDown();
			moveDOWN().enabled = !moveDOWN().enabled;
			moveLEFT().enabled = !moveLEFT().enabled;
			moveRIGHT().enabled = !moveRIGHT().enabled;
		}
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
