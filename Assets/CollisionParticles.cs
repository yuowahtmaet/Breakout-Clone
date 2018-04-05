using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionParticles : MonoBehaviour {

	public GameObject particlePrefab;

	void OnCollisionExit2D (Collision2D col)
	{
		GameObject clone = Instantiate (particlePrefab, transform.position, Quaternion.identity) as GameObject;
	}
}
