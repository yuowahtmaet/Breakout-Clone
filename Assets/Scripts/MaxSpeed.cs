using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxSpeed : MonoBehaviour 
{
	[SerializeField]
	private float maxSpeed;
	[SerializeField]
	private float minSpeed;
	private Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate ()
	{
		if (Mathf.Abs(rb.velocity.x) < minSpeed) 
		{
			float newVelocity = rb.velocity.x * 1.1f;
			rb.velocity = new Vector2(newVelocity, rb.velocity.y);
		}
		if (Mathf.Abs(rb.velocity.y) < minSpeed) 
		{
			float newVelocity = rb.velocity.y * 1.1f;
			rb.velocity = new Vector2(rb.velocity.x, newVelocity);
		}
		if(rb.velocity.magnitude > maxSpeed)
		{
			rb.velocity = rb.velocity.normalized * maxSpeed;
		}
	}
}
