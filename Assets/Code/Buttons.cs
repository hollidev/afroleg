using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartButton(){
		Application.LoadLevel ("eka"); //start game
	}

	public void ExitButton(){
		Application.Quit (); //exit game
	}

}
