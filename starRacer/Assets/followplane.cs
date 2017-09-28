using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplane : MonoBehaviour {
	private int speed = 40;
	public Rigidbody rb;
	public Transform planePos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		// if we want camera to follow movements
		Vector3 newPos = planePos.position;
		newPos.y += 2;
		newPos.z -= 5;
		transform.position = newPos;
		if (Input.GetKey(KeyCode.Space))
		{
			speed = 80;     
		} else {
			speed = 40;
		}
		//rb.velocity = Vector3.forward * speed ;
	}
}
