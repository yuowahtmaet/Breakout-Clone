using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnCollision : MonoBehaviour {

	public GameObject preFab;

	void OnCollisionExit2D (Collision2D col)
	{
		GameObject clone = Instantiate (preFab,transform.position, Quaternion.identity) as GameObject;
		Destroy (gameObject);
	}
}
