using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class H_Score : MonoBehaviour {

	public Text[] pisteet;


	// Use this for initialization
	void Start () {

		string key = "highScore";

		string lukuS;

		for(int i=1; i<=10; i++)
		{
			key = "highScore" + i;
			lukuS = PlayerPrefs.GetInt(key).ToString();
			pisteet[i-1].text = lukuS;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
