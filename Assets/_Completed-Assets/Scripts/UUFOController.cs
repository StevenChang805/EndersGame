using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUFOController : MonoBehaviour {

	public class Health
	{
		public int health;

		public Health(int hp)
		{
			health = hp;
		}
	}

	public Health myHealth = new Health (100);

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
}
