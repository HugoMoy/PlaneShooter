using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class planemanager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnCollisionEnter(Collision collision)
    {

		SceneManager.LoadScene("AwesomeScene");
		Debug.Log("Hit !!!");
		Debug.Log( "collide (name) : " + collision.collider.gameObject.name );
 		Debug.Log( "collide (tag) : " + collision.collider.gameObject.tag );
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        
    }
	// Update is called once per frame
	void Update () {
		
	}
}
