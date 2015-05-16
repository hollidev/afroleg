using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {
	
	public Canvas pauseCanvas;

	public static bool seis = false;

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
						

						seis = true;
						

						temp = Time.timeScale;  //pelkästää timen debukkaukseen käytetään
						Debug.Log(temp);

					}
				
				else
					{
						pauseCanvas.enabled = false;
						Time.timeScale = 1;

						seis = false;
						
						temp = Time.timeScale;
						Debug.Log(temp);
					}
				}
	}


	public void ResumeButton(){
		pauseCanvas.enabled = false;
		seis = false;
		Debug.Log("resumen lopussa");
	}

	public void RestartButton(){
		pauseCanvas.enabled = false;
		Application.LoadLevel("eka");
	}

	public void MainmenuButton(){
		Application.LoadLevel("Start_scene");
	}



}
