using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOHealth : MonoBehaviour {

	public int maxHealth = 100; 
	public int curHealth = 100;

	//initialization 
	void Start () { 
	
	} 

	// Update 
	void Update () { 
		if (curHealth <1){ 
			Destroy(gameObject); 
		} 
	} 
	void OnCollisionEnter(Collision col) { 
		if (col.gameObject.tag == "Bullet") { 
			curHealth -= 20;
			Destroy (col.collider);
		} 
	}
}
