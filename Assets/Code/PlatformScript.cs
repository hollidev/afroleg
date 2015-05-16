using UnityEngine;
using System.Collections;

public class PlatformScript : MonoBehaviour {



	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision col) {

		if (col.gameObject.tag == "AfroClone") {
			Destroy (col.gameObject, 0.5f);
			Debug.Log ("afroclone destroyed");
		}
		else if (col.gameObject.tag == "SaksiClone") {
			Destroy (col.gameObject, 0.5f);
			Debug.Log ("saksiclone destroyed");
		}
	}


}
