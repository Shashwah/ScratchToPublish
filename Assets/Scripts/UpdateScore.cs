using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpdateScore : MonoBehaviour {

	public Text scoreText = null;
	public int score = 0;

	// Use this for initialization
	void Start () {
		Debug.Log ("Score Text Object Set To: " + scoreText.name);
		scoreText.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {
		score++;
		scoreText.text = "Score: " + score;
	}
}