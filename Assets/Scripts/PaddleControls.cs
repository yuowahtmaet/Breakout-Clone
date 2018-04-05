using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControls : MonoBehaviour 
{

	[SerializeField]
	private int speed;
	private Rigidbody2D rb;

	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update () 
	{
		Vector3 mousePos = Input.mousePosition;
		Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 targetPosition = new Vector2(worldPos.x, transform.position.y);


        rb.MovePosition(Vector3.Lerp(transform.position,targetPosition,Time.deltaTime*speed));

		//float hAxis = Input.GetAxis ("Horizontal");

		//Vector3 movement = new Vector2 (hAxis, 0)* speed * Time.deltaTime;

		//rb.MovePosition (transform.position + movement);
		//rb.AddForce(movement);
	}
}
