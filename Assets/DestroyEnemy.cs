using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour {

	public GameObject explosion;
	int randomNumber;

	// Use this for initialization
	void Start () 
	{
		randomNumber = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		randomNumber = (int)Random.Range (0, 4);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "bullet") 
		{
			
			if (randomNumber == 0) {
				GameObject poof = (GameObject)Instantiate (explosion, transform.position, Quaternion.Euler (0, 0, 0));
			}

			else if (randomNumber == 1) {
				GameObject poof = (GameObject)Instantiate (explosion, transform.position, Quaternion.Euler (0, 0, 90f));
			}

			else if (randomNumber == 2) {
				GameObject poof = (GameObject)Instantiate (explosion, transform.position, Quaternion.Euler (0, 0, 180f));
			}

			else {
				GameObject poof = (GameObject)Instantiate (explosion, transform.position, Quaternion.Euler (0, 0, 270f));
			}

			GameState.score += 100f;

			Destroy (other.gameObject);
			Destroy (this.gameObject);
		}
	}
}
