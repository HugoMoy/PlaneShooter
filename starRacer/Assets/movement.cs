using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class movement : MonoBehaviour {

	private float minX = -20;
	private float minY = -5;
	private float maxX = 30;
	private float maxY = 30;
	private int speed = 40;

	public Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision)
    {
		Debug.Log("Hit !!!");
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        
    }
	void FixedUpdate() {
		
		//mv2();
		//Debug.Log(transform.rotation);
		//Debug.Log(transform.rotation.x + "  " + transform.rotation.y + " " + transform.rotation.z);
		//Debug.Log(transform.position.x + "  " + minX);
		Quaternion rot1 = new Quaternion(0.7f,0,0,-0.7f);
		transform.rotation = rot1;   
		if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > minX)
		{
			//Debug.Log("left");
			transform.position += Vector3.left * speed/2 * Time.deltaTime;
			Quaternion rot = new Quaternion(0.7f,0.2f,0,-0.7f);
			transform.rotation = rot;         }
		else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < maxX)
		{
			//Debug.Log("right");
			transform.position += Vector3.right * speed/2 * Time.deltaTime;
			Quaternion rot = new Quaternion(0.7f,-0.2f,0,-0.7f);
			transform.rotation = rot;   
		}
		if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < maxY)
		{
			//Debug.Log("up");
			transform.position += Vector3.up * speed/4 * Time.deltaTime;
			Quaternion rot = new Quaternion(0.7f,0,0,-0.5f);
			transform.rotation = rot;   
		}
		else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > minY)
		{
			//Debug.Log("down");
			transform.position += Vector3.down * speed/4 * Time.deltaTime;
			Quaternion rot = new Quaternion(0.7f,0,0,-0.9f);
			transform.rotation = rot;   
		}
		rigidbody.velocity = Vector3.forward * speed ;

		if (Input.GetKey(KeyCode.Space))
		{
			speed = 80;     
		} else {
			speed = 40;
		}
		 //Debug.Log("Position is : "+ transform.position.x + " ahah " + transform.position.y);
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