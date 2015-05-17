using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public Canvas scoreCanvas;
	int score;
	public Text scoreText;

	void Start(){
		scoreCanvas.enabled = false;

		score = PlayerPrefs.GetInt ("endScore");
		Debug.Log ("Endscore: " + score);
		//TODO
		//tarkistaa onko pistemäärä riittävän suuri tilastolle pääsyyn, jos on
		//pitää canvas enabloida

		scoreText.text = "Score: " + score;
	}
	
	void Update()
	{

	}
	

	
	
	
}
