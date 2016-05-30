using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour {
	public Transform playerTransform;
	private Vector3 selfPosition;
	// Use this for initialization
	void Start () {
		selfPosition = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = playerTransform.position + selfPosition;
		transform.rotation = playerTransform.rotation;
//		Debug.Log (playerTransform.getRo);
	}
}
