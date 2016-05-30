using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float moveSpeed = 10f;
	public float rotationSpeed = 10.0F;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		transform.Rotate(Vector3.up *Time.deltaTime * TranslateSpeed);//绕Y轴 旋转 

		float translation = Input.GetAxis("Vertical") * moveSpeed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate (0, rotation, 0);
	}
}
