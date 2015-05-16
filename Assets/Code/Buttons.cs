using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {
	public Canvas pauseCanvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	/// <summary>
	/// menuvalikon buttonit
	/// </summary>

	public void StartButton(){
		Application.LoadLevel ("eka"); //start game
	}

	public void MainMenu_Button(){
		Application.LoadLevel ("Start_scene");
	}

	public void ExitButton(){
		Application.Quit (); //exit game
	}

	public void ScoreButton(){
		Application.LoadLevel("Score_scene");
	}

	/// <summary>
	/// Gamebuttons
	/// </summary>
	public void StopButton(){
		pauseCanvas.enabled = true;
		Time.timeScale = 0;
	}
}
