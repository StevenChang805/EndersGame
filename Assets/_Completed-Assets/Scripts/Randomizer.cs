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

		if (Input.GetKeyDown (KeyCode.Space))
			Randomize ();

		if (Input.GetKeyDown (KeyCode.Escape))
			nextTurn ();

	}

	void Randomize() {

		float myInt = (Random.value * 10);

		if (myInt <= 5) 
		{
			Debug.Log ("Player One goes first!");

			UUFO.GetComponent<UUFOController>().enabled = !UUFO.GetComponent<UUFOController>().enabled;
			Shooter2.GetComponent<ShooterController>().enabled = !Shooter2.GetComponent<ShooterController>().enabled;

		}
		else
		{
			Debug.Log ("Player Two goes first!");

			UFO.GetComponent<UFOController>().enabled = !UFO.GetComponent<UFOController>().enabled;
			Shooter1.GetComponent<ShooterController> ().enabled = !Shooter1.GetComponent<ShooterController> ().enabled;

		}

	}

	void nextTurn() 
	{
			UFO.GetComponent<UFOController>().enabled = !UFO.GetComponent<UFOController>().enabled;
			Shooter1.GetComponent<ShooterController> ().enabled = !Shooter1.GetComponent<ShooterController> ().enabled;
			Shooter1.SendMessage ("Reload");

			UUFO.GetComponent<UUFOController>().enabled = !UUFO.GetComponent<UUFOController>().enabled;
			Shooter2.GetComponent<ShooterController>().enabled = !Shooter2.GetComponent<ShooterController>().enabled;
			Shooter2.SendMessage ("Reload");
	}
}
