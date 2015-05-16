using UnityEngine;
using System.Collections;

public class SaksiBehaviour : MonoBehaviour {
	public Transform saksi;
	public GameObject platform;
	int updateCounter = 0;
	float scale;

	int afroCounter;
	float pos;
	
	void Start () {
		scale = platform.transform.localScale.x;

		
	}
	
	// Update is called once per frame
	void Update () {
		updateCounter ++;
		
		if (updateCounter % 300 == 0) {
			Transform obj = Instantiate(saksi);
			GameObject saksiClone = obj.gameObject;
			saksiClone.tag = "SaksiClone";
			pos = Random.Range (0, scale);
			saksiClone.transform.position = new Vector3 (pos,568f);
			//enableGravity(littleAfro);
			//fallSpeed = Random.Range (1f, 10f);
			Debug.Log ("saksiclone created");

		}


	}

}
