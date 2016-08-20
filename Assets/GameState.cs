using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameState : MonoBehaviour {

	public static float score;
	public static float lives;

	public Text score_text;
	public Text lives_text;

	// Use this for initialization
	void Start () 
	{
		score = 0f;
		lives = 0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		score_text.text = GameState.score.ToString ();

		lives_text.text = GameState.lives.ToString ();
	}
}
