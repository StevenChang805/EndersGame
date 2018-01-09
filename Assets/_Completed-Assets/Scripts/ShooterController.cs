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

	public Inventory myInventory = new Inventory (20, 50);

	public float speed;
	public float turnSpeed;
	public Rigidbody2D bulletPrefab;
	public Transform firePosition;
	public float bulletSpeed;


	void Update ()
	{
		Movement();
		Shoot(); 
	}


	void Movement ()
	{
		float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

		transform.Translate(Vector3.forward * forwardMovement);
		transform.Rotate(Vector3.forward * turnMovement);
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
		if (Input.GetKeyDown (KeyCode.T))
			myInventory.bullets++;
	}
 
}
