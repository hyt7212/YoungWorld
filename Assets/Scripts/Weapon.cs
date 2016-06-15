using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public GameObject shellPfb;
	public Transform shellPoint;
	public float shootPower;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Shoot ();
		}
	}

	void Shoot () {
		GameObject newShell = Instantiate (shellPfb, shellPoint.position, shellPoint.rotation) as GameObject;
		Rigidbody r = newShell.GetComponent<Rigidbody> ();
		r.velocity = shellPoint.forward * shootPower;
	}
}
