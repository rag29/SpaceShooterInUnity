using UnityEngine;
using System.Collections;

public class BackgroundScroll : MonoBehaviour {

	public float timer;

	Vector3 startPos;

	// Use this for initialization
	void Start () 
	{
		timer = 0f;
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime;

		transform.position += Vector3.down * Time.deltaTime;

		if (timer > 20.2f) 
		{
			transform.position = startPos;
			timer = 0f;
		}


	}
}
