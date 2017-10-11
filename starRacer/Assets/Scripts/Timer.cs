using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text timerText;
	public Text timerText2;
	public Text timerText3;
	public Text timerText4;

	public static bool paused = true;
	public static int currentTimer = 1;
	public static bool timerFinished = false;

	private float starttime;
	private bool finnished = false;

	// Use this for initialization
	void Start () {
		starttime = Time.time;
		Debug.Log("Started timer ");
	}
	
	// Update is called once per frame
	void Update () {
		if (paused) {
			return;
		}

		float t = Time.time - starttime;

		if (timerFinished) {
			finnish ();
			timerFinished = false;
		}

		if (currentTimer == 1) {
			timerText.text = getTime (t);
		} else if (currentTimer == 2) {
			timerText2.text = getTime (t);
		} else if (currentTimer == 3) {
			timerText3.text = getTime (t);
		} else {
			timerText4.text = getTime (t);
		}

	}

	public string getTime(float t) {
		string minutes = ((int)t / 60).ToString ();
		string seconds = (t % 60).ToString ("f2");

		if (seconds.Length == 4) {
			seconds = "0" + seconds;
		}

		if (minutes.Length == 1) {
			minutes = "0" + minutes;
		}

		return minutes + ":" + seconds;
	}

	public void finnish() {
		if (currentTimer == 1) {
			timerText.color = Color.yellow;
		} else if (currentTimer == 2) {
			timerText2.color = Color.yellow;
		} else {
			timerText3.color = Color.yellow;
		}
				
		starttime = Time.time;
		currentTimer++;
	}

	public static void currentTimerFinished() {
		timerFinished = true;
	}

	public static void unpause() {
		paused = false;
	}

	public static void pause() {
		paused = true;
	}
}
