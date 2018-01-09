using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {

	public static UFOController Instance;

	public int health = 100;
	public Collider2D collider_ufo;

	private float speed = 10;
	private Rigidbody2D rb2d;

	void Awake() 
	{
		Instance = this;
	}

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

	void onColliderTrigger (Collision col)
	{
		if (col.gameObject.tag == "Bullet") 
		{
			health -= 20;
		}
	}
}
