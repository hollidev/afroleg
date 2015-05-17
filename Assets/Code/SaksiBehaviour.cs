using UnityEngine;
using System.Collections;

public class SaksiBehaviour : MonoBehaviour {
	public Transform saksi;
	public GameObject platform;
	Rigidbody2D rb;
	int updateCounter = 0;
	float scale;
	float drag;
	int afroCounter;
	float pos;
	float mass;
	float force;
	
	void Start () {
		scale = platform.transform.localScale.x;

		
	}
	
	// Update is called once per frame
	void Update () {
		if(PauseScript.seis==false){

		updateCounter ++;
		
		if (updateCounter % 10 == 0) {
			Transform obj = Instantiate(saksi);
			GameObject saksiClone = obj.gameObject;
			rb = saksiClone.GetComponent<Rigidbody2D>();
			force = Random.Range (1000f,22000f);
			rb.AddForce(Vector3.down * force);
			saksiClone.tag = "SaksiClone";
			pos = Random.Range (0, scale);
			saksiClone.transform.position = new Vector3 (pos,568f);
			Debug.Log ("saksiclone created");

		}
		}

	}

}
