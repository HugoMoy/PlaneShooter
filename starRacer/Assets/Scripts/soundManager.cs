using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour {
	public static AudioSource[] allAudioSources;

	// Use this for initialization
	void Start () {
		StopAllAudio ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void StarAllAudio() {
		allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
		foreach( AudioSource audioS in allAudioSources) {
			audioS.Play();
		}
	}

	public static void StopAllAudio() {
		allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
		foreach( AudioSource audioS in allAudioSources) {
			audioS.Stop();
		}
	}
}
