using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private void FixedUpdate ()
	{
		float x = Input.GetAxis ("Horizontal");	// Horizontal は水平方向
		float z = Input.GetAxis("Vertical");	// Vertical は垂直方向		
	
	
		Rigidbody rigidbody = GetComponent<Rigidbody> (); 


		rigidbody.AddForce (x * 5, 0, z * 5);
    }
}
