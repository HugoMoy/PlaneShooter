using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {

    GameObject[] pauseObjects;

    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("Pause");
        hidePaused();
    }
    
    // Update is called once per frame
    void Update () {
        if(Input.GetKeyDown(KeyCode.P)) {
            if(Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showPaused();
            } else if (Time.timeScale == 0){
                //Debug.Log ("high");
                Time.timeScale = 1;
                hidePaused();
            }
        }
    }

    //shows objects with ShowOnPause tag
    public void showPaused(){
        foreach(GameObject g in pauseObjects){
            g.SetActive(true);
        }

//        foreach(GameObject g in gameplayObjects){
//            g.SetActive(false);
//        }
    }

    //hides objects with ShowOnPause tag
    public void hidePaused(){
        foreach(GameObject g in pauseObjects){
            g.SetActive(false);
        }

//        foreach(GameObject g in gameplayObjects){
//            g.SetActive(true);
//        }
    }
}