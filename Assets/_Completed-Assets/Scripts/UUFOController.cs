using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUFOController : MonoBehaviour {

	public int health = 100;
	public Collider2D collider_ufo;

	private float speed = 10;
	private Rigidbody2D rb2d;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void Update()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		rb2d.AddForce (movement * speed);
	}


	void Decrement() 
	{
		health -= 20;

		if (health == 0)
			Destroy(gameObject);;
	}

}