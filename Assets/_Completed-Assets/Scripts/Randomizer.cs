using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour {

	public GameObject UFO;
	public GameObject UUFO;
	public GameObject Shooter1;
	public GameObject Shooter2;

	// Use this for initialization
	void Start () {

		float myInt = (Random.value);

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Alpha5))
			Begin ();

		if (Input.GetKeyDown (KeyCode.Space))
			Randomize ();

		if (Input.GetKeyDown (KeyCode.Escape))
			nextTurn1 ();
		
		if (Input.GetKeyDown (KeyCode.Tab))
			nextTurn2 ();

		if (Input.GetKeyDown (KeyCode.Alpha1))
			colliders1 ();

		if (Input.GetKeyDown (KeyCode.Alpha2))
			shooters1 ();

		if (Input.GetKeyDown (KeyCode.Alpha3))
			colliders2 ();

		if (Input.GetKeyDown (KeyCode.Alpha4))
			shooters2 ();

	}

	void Randomize() {

		float myInt = (Random.value * 10);

		if (myInt <= 5) 
		{
			Debug.Log ("Player One goes first!");

			UUFO.GetComponent<UUFOController>().enabled = false;
			Shooter2.GetComponent<ShooterController2>().enabled = false;

		}
		else
		{
			Debug.Log ("Player Two goes first!");

			UFO.GetComponent<UFOController>().enabled = false;
			Shooter1.GetComponent<ShooterController> ().enabled = false;

		}
	}

	void Begin()
	{
		UFO.SetActive (true);
		UUFO.SetActive (true);
		Shooter1.SetActive (true);
		Shooter2.SetActive (true);
	}

	void nextTurn1() 
	{
		UFO.GetComponent<UFOController> ().enabled = true;
		Shooter1.GetComponent<ShooterController> ().enabled = true;
		Shooter1.SendMessage ("Reload");

		UUFO.GetComponent<UUFOController> ().enabled = false;
		Shooter2.GetComponent<ShooterController2> ().enabled = false;
	}

	void nextTurn2()
	{
		UFO.GetComponent<UFOController> ().enabled = false;
		Shooter1.GetComponent<ShooterController> ().enabled = false;

		UUFO.GetComponent<UUFOController> ().enabled = true;
		Shooter2.GetComponent<ShooterController2> ().enabled = true;
		Shooter2.SendMessage ("Reload");
	}

	void colliders1 ()
	{
		UFO.GetComponent<UFOController> ().enabled = true;
		Shooter1.GetComponent<ShooterController> ().enabled = false;
	}

	void shooters1 ()
	{
		UFO.GetComponent<UFOController> ().enabled = false;
		Shooter1.GetComponent<ShooterController> ().enabled = true;
	}

	void colliders2 ()
	{
		UUFO.GetComponent<UUFOController> ().enabled = true;
		Shooter2.GetComponent<ShooterController2> ().enabled = false;
	}

	void shooters2 ()
	{
		UUFO.GetComponent<UUFOController> ().enabled = false;
		Shooter2.GetComponent<ShooterController2> ().enabled = true;
	}

}
