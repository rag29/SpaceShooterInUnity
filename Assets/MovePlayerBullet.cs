using UnityEngine;
using System.Collections;

public class MovePlayerBullet : MonoBehaviour {

	float moveSpeed;
	float destroyTimer;

	// Use this for initialization
	void Start () 
	{
		moveSpeed = 5.5f;
		destroyTimer = 0f;

	}
	
	// Update is called once per frame
	void Update () {
	
		this.transform.position += Vector3.up * Time.deltaTime * moveSpeed;

		destroyTimer += Time.deltaTime;

		if (destroyTimer > 2f) 
		{
			Destroy (this.gameObject);
		}
	}
}
