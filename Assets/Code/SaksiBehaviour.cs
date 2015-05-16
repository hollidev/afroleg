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
		
		if (updateCounter % 100 == 0) {
			Instantiate(saksi);
			saksi.tag = "SaksiClone";
			pos = Random.Range (0, scale);
			littleAfro.transform.position = new Vector3 (pos,568f);
			//enableGravity(littleAfro);
			fallSpeed = Random.Range (1f, 10f);
			Debug.Log ("clone created");
		}
	}
}
