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
		// other option y += 2 and z += 7	
		// other option y += 1 and z += 4	

		Vector3 newPos = planePos.position;
		newPos.y += 1;
		newPos.z -= 4;
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
