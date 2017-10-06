using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class btnmanager : MonoBehaviour {
	OtherScript target;
	public void NewGameButton(string NewGameLevel) {
		GameObject.Find("GameObject").GetComponent(movement).letsgo();
	}

	public void MainMenuButton(string NewGameLevel) {
		//SceneManager.LoadScene(NewGameLevel);
	}

	public void ExitGameButton(){
		Application.Quit();
} 
}
