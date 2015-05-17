using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class ShowScoreScript : MonoBehaviour {
	public Text scoreText;
	int score;

	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("endScore");
		scoreText.text = "" + score;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
