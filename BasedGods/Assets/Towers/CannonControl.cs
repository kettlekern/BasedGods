﻿using UnityEngine;
using System.Collections;

public class CannonControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerStay(Collider other)
	{
		transform.LookAt (other.transform.position);
	}
}
