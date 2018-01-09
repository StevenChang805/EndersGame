using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public GameObject UFO;
	public Collider collider_bullet;

	public int damage = 20;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () {
	}
	void DestroyBullet() 
	{
		DestroyObject (this);
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Player") 
		{
			UFOController.Instance.health -= damage;
			DestroyBullet ();
		}
	}
}
