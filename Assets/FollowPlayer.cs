using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	// Use this for initialization
	public Transform Player;

	private Vector3 offset;

	private void Start ()
	{

		offset = GetComponent<Transform> ().position - Player.position;
	}

		

	
	// Update is called once per frame
	private void Update () 
	{

		GetComponent<Transform> ().position = Player.position + offset;
	}
}
