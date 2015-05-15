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
						
						temp = Time.timeScale;
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


}
