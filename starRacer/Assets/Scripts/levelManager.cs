﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class levelManager : MonoBehaviour {
	public static List<GameObject> levelPrefabs;
	int levels = 3;

	// Use this for initialization
	void Start () {
		levelPrefabs = new List<GameObject> ();

		levelPrefabs.Add(GameObject.FindGameObjectsWithTag ("Tutorial")[0]);
		levelPrefabs.Add(GameObject.FindGameObjectsWithTag ("LEVEL1")[0]);
		levelPrefabs.Add(GameObject.FindGameObjectsWithTag ("LEVEL2")[0]);

		EnabledLevel (0);
		DisabledLevel (1);
		DisabledLevel (2);	
	}

	// Update is called once per frame
	void Update () {

	}

	public static void DisabledLevel(int lvlnumber) {
		ChangeStatusLevel(levelPrefabs[lvlnumber], false);
	}

	public static void EnabledLevel(int lvlnumber) {
		if(lvlnumber == 3) {
			SceneManager.LoadScene("WinScene");
			return;
		}
		ChangeStatusLevel(levelPrefabs[lvlnumber], true);
	}

	private static void ChangeStatusLevel(GameObject lvl, bool status) {
		lvl.SetActive (status);
	}
}
