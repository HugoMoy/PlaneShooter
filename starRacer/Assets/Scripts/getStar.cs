using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getStar : MonoBehaviour {

public GameObject score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,0,1f);
	}

	void OnTriggerEnter() {
		Debug.Log("You got a Star !");
		Destroy(this.gameObject);
		score.GetComponent<scoremanager>().AddStar();
		// reduce time of 3 sec
	}
}
