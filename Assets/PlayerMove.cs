using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public GameObject bullet; 

	float moveSpeed;
	float coolDownTime;
	float canAttackTime;

	// Use this for initialization
	void Start () 
	{
		moveSpeed = 4f;

		//canAttackTime = 0f;
		//coolDownTime = 1f;
	}

	// Update is called once per frame
	void Update () 
	{
		Move();

		canAttackTime = Time.time + coolDownTime;

		if (Input.GetKeyDown (KeyCode.Mouse0) ) 
		{
			Attack ();
		}
	}

	void Move()
	{
		if (Input.GetAxis ("Horizontal") > 0) 
		{
			transform.position += Vector3.right * Time.deltaTime * moveSpeed;
		}

		else if (Input.GetAxis ("Horizontal") < 0) 
		{
			transform.position += Vector3.left * Time.deltaTime * moveSpeed;
		}
	
	}

	void Attack()
	{
		GameObject shot = (GameObject)Instantiate (bullet, transform.position, Quaternion.Euler (0, 0, 0));
	}
}
