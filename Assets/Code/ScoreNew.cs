using UnityEngine;
using System.Collections;

public class ScoreNew : MonoBehaviour {
	string key;
	int keyscore;
	Hashtable test;
	// Use this for initialization
	void Start () {


		for (int i = 9; i<-1; i--) {
			key = "key" + i;
			keyscore = PlayerPrefs.GetInt(key);
			test.Add (key, keyscore);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
