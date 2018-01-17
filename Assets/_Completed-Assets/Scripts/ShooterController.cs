 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterController : MonoBehaviour {

	public class Inventory
	{
		public int bullets;
		public int health;

		public Inventory (int bul, int hp)
		{
			bullets = bul;
			health = hp;
		}
	}

	private float speed = 100000;
	private Rigidbody2D rb2d;

	public Inventory myInventory = new Inventory (1, 70);

	public Rigidbody2D bulletPrefab;
	public Transform firePosition;
	public float bulletSpeed;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}


	void Update ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		rb2d.AddForce (movement * speed);

		Rotate ();
		Shoot(); 
	}

	void Rotate ()
	{
		if (Input.GetKeyDown (KeyCode.T))
			transform.Rotate (new Vector3 (0, 0, 90));
	}
	


	void Shoot ()
	{
		if(Input.GetButtonDown("Fire1") && myInventory.bullets > 0)
		{
			Rigidbody2D bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody2D;
			bulletInstance.AddForce(firePosition.right * bulletSpeed);
			myInventory.bullets--;
		}
	}

	void Reload()
	{
		if (myInventory.bullets == 0) 
		{
			myInventory.bullets++;
		}
	}

	void Decrement()
	{
		myInventory.health--;

		if (myInventory.health == 0) {
			Debug.Log ("Shooter 1 has been destroyed");
			gameObject.SetActive (false);
		}
	}
 
}
