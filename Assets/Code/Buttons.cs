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

	// audio esittely


	/// <summary>
	/// menuvalikon buttonit
	/// </summary>

	public void StartButton(){
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		Debug.Log ("startbutton");
		StartCoroutine ("waitAudio");

	}

	IEnumerator waitAudio()
		{

		yield return new WaitForSeconds( 0.5f); 
		Application.LoadLevel ("eka"); //start game
		

		}

	public void MainMenu_Button(){
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		StartCoroutine ("waitAudio3");

	}

	IEnumerator waitAudio3()
	{
		
		yield return new WaitForSeconds( 0.5f); 
		Application.LoadLevel ("Start_scene");
		
	}



	public void ExitButton(){

		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		StartCoroutine ("waitAudio2");

	}

	IEnumerator waitAudio2()
	{

		yield return new WaitForSeconds( 0.5f); 
		Application.Quit (); //exit game
	
	}




	public void ScoreButton(){
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		StartCoroutine ("waitAudio4");

	}

	IEnumerator waitAudio4()
	{
		
		yield return new WaitForSeconds( 0.5f); 
		Application.LoadLevel("Score_scene");
		
	}




	/// <summary>
	/// Gamebuttons
	/// </summary>
	public void StopButton(){
		pauseCanvas.enabled = true;
		Time.timeScale = 0;
		PauseScript.seis=true;
	}
}
