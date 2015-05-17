using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public Canvas scoreCanvas;
	int score;
	int highScore;
	public Text scoreText;
	//public Text[] pisteet;
	

	void Start(){
		scoreCanvas.enabled = false;

		score = PlayerPrefs.GetInt ("endScore");
		Debug.Log ("Endscore: " + score);

		scoreText.text = "" + score;


		//TODO
		//tarkistaa onko pistemäärä riittävän suuri tilastolle pääsyyn, jos on
		//pitää canvas enabloida

		/*int pistemaara;
		Debug.Log("int pisteille luotu, ei vielä for luuppiin"+pisteet.Length);
		for(int i=0; i<pisteet.Length; i++)
		{
			pistemaara = int.Parse(pisteet[i].text);
			Debug.Log("" + pistemaara);

		}*/

		//int asetusmuisti = 0;
		string key = "key";
		int keyscore;

		//Debug.Log("ennen silmukkaa");

		for(int i=9; i>-1; i--)
		{
			//Debug.Log("silmukan sisällä");
			/*tämä on vain sitä varten, että sain jotain lukuja noihin muisteihin
			 * 
			key = "key" + i;
			Debug.Log(key);
			PlayerPrefs.SetInt (key, asetusmuisti);
			asetusmuisti = asetusmuisti + 5;

			key = "key" + i;
			Debug.Log("tallennusindeksi" + key);

			PlayerPrefs.SetInt (key, asetusmuisti);
			asetusmuisti = asetusmuisti++;
			Debug.Log (asetusmuisti);*/


			key = "key" + i;
			keyscore = PlayerPrefs.GetInt(key);
			int pudotusmuisti;


			//tämän sisään jos pistetulos pelistä on suurempi kuin arvo tilastossa
			if(keyscore < score)
			{
				//siirretään korvattava arvo talteen
				pudotusmuisti = keyscore;

				
				//alhaaltalukien siirretään pienemmät luvut aina alempaan muistiin
				string toinen;
				for(int j = 0; j < i; j++){
					key="key"+j;
					toinen="key"+j++;
					PlayerPrefs.SetInt(key, PlayerPrefs.GetInt(toinen));
					}

				//tallennetaan muistipaikkaan score
				key = "key" + i;
				PlayerPrefs.SetInt(key, score);
				i = -2;
			}

		}


	}



	void Update()
	{

	}
	

	
	
	
}
