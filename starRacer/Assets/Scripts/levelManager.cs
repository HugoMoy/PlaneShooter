using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		EnabledLevel ("LEVEL1");
		DisabledLevel ("LEVEL2");
		DisabledLevel ("LEVEL3");	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	public static void DisabledLevel(string namelevel) {
		ChangeStatusLevel(namelevel, false);
	}

	public static void EnabledLevel(string namelevel) {
		ChangeStatusLevel(namelevel, true);
	}

	private static void ChangeStatusLevel(string namelevel, bool status) {
		GameObject[] levelPrefabs = GameObject.FindGameObjectsWithTag (namelevel);

		foreach (GameObject go in levelPrefabs) {
			go.SetActive (status);
		}
	}
}
