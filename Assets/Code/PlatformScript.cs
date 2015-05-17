using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlatformScript : MonoBehaviour {



	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D col) {

		if (col.gameObject.tag == "AfroClone") {
			Destroy (col.gameObject, 0.5f);

		}
		else if (col.gameObject.tag == "SaksiClone") {
			Destroy (col.gameObject, 0.5f);

		}
	}


}
