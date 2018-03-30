﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddVelocity : MonoBehaviour 
{

	[SerializeField]
	private float speed;
	void Start () 
	{
		GetComponent<Rigidbody2D> ().velocity = new Vector3 (speed, -speed, 0);
	}
}
