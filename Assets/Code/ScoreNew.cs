using UnityEngine;
using System.Collections;

public class ScoreNew : MonoBehaviour {
	string key;
	int keyscore;
	Hashtable test;
	int lowestScore;
	// Use this for initialization
	void Start () {
		test = new Hashtable();
		ArrayList list = new ArrayList ();
		int score = PlayerPrefs.GetInt ("endScore");


		for (int i = 1; i<=10; i++) {
			key = "highScore" + i;
			keyscore = PlayerPrefs.GetInt(key);
			list.Add(keyscore);


			//PlayerPrefs.SetInt (key, 0);
		}

		lowestScore = PlayerPrefs.GetInt ("highScore10");
		Debug.Log ("lowest score" + lowestScore);

		if (score > lowestScore) 
		{
			list.Add (score);
			list.Sort ();
			list.Reverse();
			list.RemoveAt(10);

			for (int i = 1; i<=10; i++) {
				key = "highScore" + i;
				PlayerPrefs.SetInt(key, (int)list[i-1]);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
