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
	void Update () {
		// if we want camera to follow movements
		//Vector3 newPos = new Vector3(planePos.position.x, planePos.position.y+5,transform.position.z);
		//transform.position = newPos;
		rb.velocity = Vector3.forward * speed ;
	}
}
