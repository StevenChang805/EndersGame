using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public GameObject UFO;
	public Collision col1;
	public UFOController UFOC;
	public Collider collider_bullet;

	public int damage = 20;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{

	}
	void DestroyBullet() 
	{
		DestroyObject (this);
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player")
			coll.gameObject.SendMessage ("Decrement");
	}
}
