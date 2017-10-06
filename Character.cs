using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow)) {			
			GetComponent<Animator> ().Play ("Run");
		} else if (Input.GetKeyUp (KeyCode.RightArrow)) {
			GetComponent<Animator> ().Play ("Idle");
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			GetComponent<Rigidbody2D> ().AddForce (Vector3.right * 5f);
		} else if (Input.GetKeyDown (KeyCode.Space)) {
			
			GetComponent<Animator>().Play("Jump");
		}
	}



	public void Jump()
	{
		GetComponent<Rigidbody2D> ().AddForce (Vector3.up * 250f);
	}

}
