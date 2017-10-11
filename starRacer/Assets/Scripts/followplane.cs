using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplane : MonoBehaviour {
	private int speed = 40;
	public Rigidbody rb;
	public Transform planePos;
	public GameObject ship;
	public static Vector3 originalPosition;
	public static Vector3 cameraOriginalPosition;

	public static bool check = false;
	// Use this for initialization
	void Start () {
		originalPosition = planePos.position;
		cameraOriginalPosition = rb.position;
	}

	// Update is called once per frame
	void LateUpdate () {

		// if (planePos.position.z >= 1500 && !check) {
		// 	planePos.position = originalPosition;
		// 	rb.position = cameraOriginalPosition;
		// 	check = true;
		// }
		// if we want camera to follow movements
		Vector3 newPos = planePos.position;
		newPos.y += 2;
		newPos.z -= 7;
		transform.position = newPos;
		if (Input.GetKey(KeyCode.Space))
		{
			speed = 80;     
		} else {
			speed = 40;
		}
		//rb.velocity = Vector3.forward * speed ;
	}

	public void nextLevel() {
		Debug.Log("followplane next Level");
		//if(!check) {
			//planePos.position = originalPosition;
		 	//rb.position = cameraOriginalPosition;
		 	check = true;
			ship.GetComponent<movement>().nextLevel();
		//}
	}

	public static void ResetPosition() {
		//		planePos.position = originalPosition;
	}
}
