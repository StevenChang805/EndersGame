using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {

	public UFOController Instance;

	public int health = 100;
	public Collider2D collider_ufo;

	private float speed = 10;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {

		rb2d = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.W)
		{
			moveUP();
			moveLEFT().enabled = !moveLEFT().enabled;
			moveDOWN().enabled = false;
			moveRIGHT().enabled = false;
		}
		if (Input.GetKeyDown (KeyCode.A)
		{
			moveLEFT();
			moveUP().enabled = false;
			moveDOWN().enabled = false;
			moveRIGHT().enabled = false;
		}
		if (Input.GetKeyDown (KeyCode.S)
		{
			moveDOWN();
			moveUP().enabled = false;
			moveLEFT().enabled = false;
			moveRIGHT().enabled = false;
		}
		if (Input.GetKeyDown (KeyCode.D)
		{
			moveRIGHT();
			moveUP().enabled = false;
			moveDOWN().enabled = false;
			moveLEFT().enabled = false;
		}
	}
	void moveUP()
	{
		float vertical = Input.GetAxis ("Vertical");
		//0 makes sure it does not move along x-axis
		Vector2 moveVertical = new Vector2 (0, vertical);

		rb2d.AddForce (moveVertical * speed);
	}

	void moveDOWN()
	{
		float vertical = Input.GetAxis ("Vertical");
		Vector2 moveVertical = new Vector2 (0, vertical);

		rb2d.AddForce (moveVertical * speed);
	}

	void moveRIGHT()
	{
		float horizontal = Input.GetAxis ("Horizontal");
		Vector2 moveHorizontal = new Vector2 (horizontal, 0);

		rb2d.AddForce (moveHorizontal * speed);
	}

	void moveLEFT()
	{
		float horizontal = Input.GetAxis ("Horizontal");
		Vector2 moveHorizontal = new Vector2 (horizontal, 0);

		rb2d.AddForce (moveHorizontal * speed);
	}

	void Decrement() {
		health -= 20;
	}
}
