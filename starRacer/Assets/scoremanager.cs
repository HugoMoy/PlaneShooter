using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour {

	private int stars = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void AddStar() {
		stars++;
		GetComponent<Text>().text = stars.ToString();
	}
}
