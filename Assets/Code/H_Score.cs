using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class H_Score : MonoBehaviour {

	public Text[] pisteet;


	// Use this for initialization
	void Start () {

		string key = "key";
		//int luku;
		string lukuS;

		for(int i=9; i>-1; i--)
		{
			
			key = "key" + i;

			//luku = PlayerPrefs.GetInt(key);

			lukuS = PlayerPrefs.GetInt(key).ToString();

			pisteet[i].text = lukuS;

			Debug.Log("pisteideksi: " + pisteet[i] + "tallennettu muisti: " + lukuS);

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
