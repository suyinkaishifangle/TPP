using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
	public float Speed = 20;
	public Rigidbody Bullet;
	public Transform FPonit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.F)){

Rigidbody clone;

clone = (Rigidbody)Instantiate(Bullet,FPonit.position,FPonit.rotation);

clone.velocity = transform.TransformDirection(Vector3.forward*Speed); 

}
	}
}
