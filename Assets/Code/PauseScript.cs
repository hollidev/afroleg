using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {
	
	public Canvas pauseCanvas;
	void Start(){
		pauseCanvas.enabled = false;
	}
	float temp;
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
				if(pauseCanvas.enabled == false)
					{
						pauseCanvas.enabled = true;
						Time.timeScale = 0;
						
						//TODO
						//jos haluaa et pikkuafrojen tulo loppuu, tähän pitää saaha
						//semmojen et sieltä luontiscriptistä tarkistetaan onko täällä pause pällä

						temp = Time.timeScale;  //pelkästää timen debukkaukseen käytetään
						Debug.Log(temp);

					}
				
				else
					{
						pauseCanvas.enabled = false;
						Time.timeScale = 1;
						
						temp = Time.timeScale;
						Debug.Log(temp);
					}
				}
	}

	public void ResumeButton(){
		pauseCanvas.enabled = false;
	}

	public void RestartButton(){
		pauseCanvas.enabled = false;
		Application.LoadLevel("eka");
	}

	public void MainmenuButton(){
		Application.LoadLevel("Start_scene");
	}



}
