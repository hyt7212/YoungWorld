using UnityEngine;
using System.Collections;

public class Shell : MonoBehaviour {

	public GameObject explosionEffect; 
	public float explosionTimeUp;

	void OnCollisionEnter(Collision collision) {
		Object explosionObj = Instantiate (explosionEffect, transform.position, transform.rotation);
		Destroy (gameObject);
		Destroy (explosionObj, explosionTimeUp);
	}
}
