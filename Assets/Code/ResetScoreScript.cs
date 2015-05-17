using UnityEngine;
using System.Collections;

public class ResetScoreScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("endScore", 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
