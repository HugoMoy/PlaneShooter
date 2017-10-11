using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class btnmanager : MonoBehaviour {
	public GameObject plane;
	public GameObject menu;

	public void NewGameButton() {
		
		plane.GetComponent<movement>().letsgo();
		soundManager.StarAllAudio ();
		Timer.unpause();
		menu.SetActive(false);

	}

	public void MainMenuButton(string NewGameLevel) {
		//SceneManager.LoadScene(NewGameLevel);
	}

	public void ExitGameButton(){
		Application.Quit();
} 
}
