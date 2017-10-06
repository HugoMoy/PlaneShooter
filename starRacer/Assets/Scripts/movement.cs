using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class movement : MonoBehaviour {

	private float minX = -20;
	private float minY = -5;
	private float maxX = 30;
	private float maxY = 30;
	private int speed = 40;
	private int rotate = 0;
	private Quaternion rot = Quaternion.identity;//new Quaternion(0.7f,0,0,-0.7f);
	public Rigidbody rigidbody;
	private Boolean start = false;
	// Use this for initialization
	public void letsgo(){
		start = true;
		Debug.Log("Let's go !!!");
	}
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
	void OnTriggerEnter(Collider collision)
	{
		if(collision.gameObject.name == "Turn"){
			Debug.Log("HOHOHOHO");

			
			//transform.rotation = rot2
		}
	}
	void FixedUpdate() {

		if(start) {
		Quaternion inclineLeft = Quaternion.identity * Quaternion.Euler(0,0,20);
		Quaternion inclineRight = Quaternion.identity * Quaternion.Euler(0,0,-20);
		Quaternion inclineUp = Quaternion.identity * Quaternion.Euler(-20,0,0);
		Quaternion inclineDown = Quaternion.identity * Quaternion.Euler(20,0,0);
		Boolean hasMoved = false;
		
		//mv2();
		//Debug.Log(transform.rotation);
		//Debug.Log(transform.rotation.x + "  " + transform.rotation.y + " " + transform.rotation.z);
		//Debug.Log(transform.position.x + "  " + minX);
		//Debug.Log("pos"+transform.position);
		Quaternion rot1 = rot;
		transform.rotation = rot1;   
		if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > minX)
		{
			transform.position += Vector3.left * speed/2 * Time.deltaTime;
			transform.rotation = inclineLeft;  
			if (!Input.GetKey(KeyCode.Space)){
				hasMoved = true;   
			} 
			//Debug.Log()
		}
		else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < maxX)
		{
			//Debug.Log("right");
			transform.position += Vector3.right * speed/2 * Time.deltaTime;
			transform.rotation = inclineRight;   
			if (!Input.GetKey(KeyCode.Space)){
				hasMoved = true;   
			} 
		}
		if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < maxY)
		{
			//Debug.Log("up");
			transform.position += Vector3.up * speed/4 * Time.deltaTime;
			transform.rotation = inclineUp;    
			if (!Input.GetKey(KeyCode.Space)){
				hasMoved = true;   
			} 
			//Quaternion rot = new Quaternion(0,0.02f,0,0);
			//transform.rotation = rot;   
		}
		else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > minY)
		{
			transform.position += Vector3.down * speed/4 * Time.deltaTime;
			transform.rotation = inclineDown;    
			if (!Input.GetKey(KeyCode.Space)){
				hasMoved = true;   
			} 
		}
		Debug.Log(rigidbody.transform.position);
		if(hasMoved){
			transform.position += Vector3.forward/2;
		} else {
			if (Input.GetKey(KeyCode.Space)){
				transform.position += Vector3.forward*2;
			} else {
				transform.position += Vector3.forward;
			}
		}
		 //Debug.Log("Position is : "+ transform.position.x + " ahah " + transform.position.y);
		}
	}
void mv2() {
	Debug.Log(transform.rotation.eulerAngles.y );
	//Debug.Log("rot " +transform.localRotation.x);
	//Debug.Log(Math.Cos(transform.rotation.x) + "  " + Math.Sin(transform.rotation.x));
	//float Angle=Quaternion.Angle(Quaternion.Euler(new Vector3(0,0,0)),transform.rotation);

		float Angle=Quaternion.Angle(Quaternion.Euler(new Vector3(0,0,1)),transform.rotation);
		//Debug.Log(Angle);
		float ang = (transform.localEulerAngles.x+90)%360;
		float beta = 90 - ang;
		float radang = (float)(beta * Math.PI/180);
		//Debug.Log(transform.rotation.x);
		Vector3 dir = new Vector3((float)Math.Cos(radang),(float)(Math.Sin(radang)), 0);
		if(transform.rotation.x<0){
			dir = new Vector3(-(float)Math.Cos(radang),(float)(Math.Sin(radang)), 0);
		} 
	
	Vector3 rUp = new Vector3(0,1,0);

		 if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > minX)
         {
			 Debug.Log("left");
             transform.Rotate(Vector3.up * 10);
			 
		 }
         else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < maxX)
         {
			 Debug.Log("right");
             transform.Rotate(Vector3.down * 10);
         }
         if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < maxY)
         {
			 Debug.Log("up");
			 
             transform.position += dir * speed * Time.deltaTime;
         }
         else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > minY)
         {
			  Debug.Log("down");
             transform.position += -dir * speed * Time.deltaTime;
         }
		 rigidbody.velocity = Vector3.forward * speed ;
		 //Debug.Log("Position is : "+ transform.position.x + " ahah " + transform.position.y);
}
}