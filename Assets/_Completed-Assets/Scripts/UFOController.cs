using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {

	public int health = 100;
	public Collider2D collider_ufo;

	private float speed = 10;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {

		rb2d = GetComponent<Rigidbody2D>();

	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.W))
		{
			movevertical();
		}	
		if (Input.GetKeyDown (KeyCode.S))
		{
			movevertical();
		}
		else if (Input.GetKeyDown (KeyCode.A))
		{
			movehorizontal();
		}
		else if (Input.GetKeyDown (KeyCode.D))
		{
			movehorizontal();
		}
	}

	void movevertical()
	{
		float vertical = Input.GetAxis ("Vertical");
			Vector2 moveVertical = new Vector2 (0, vertical);

		rb2d.AddForce (moveVertical * speed);
	} 

	void movehorizontal()
	{
		float horizontal = Input.GetAxis ("Horizontal");
		Vector2 moveHorizontal = new Vector2 (horizontal, 0);

		rb2d.AddForce (moveHorizontal * speed);
	}

	void Decrement() 
	{
		health -= 20;
		
		if (health == 0)
			Destroy(gameObject);;
	}

}
