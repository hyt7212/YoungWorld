using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float moveSpeed = 10f;
	public float rotationSpeed = 10.0F;
	void Start () {
	
	}
	
	void Update () {
		float translation = Input.GetAxis("Vertical") * moveSpeed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate (0, rotation, 0);
	}
}
