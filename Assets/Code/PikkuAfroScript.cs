using UnityEngine;
using System.Collections;

public class PikkuAfroScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision otherObj)
	{
		Debug.Log (otherObj.gameObject.ToString() + " hit");
		Destroy ();
	}

}
