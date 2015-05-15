using UnityEngine;
using System.Collections;

public class PlatformScript : MonoBehaviour {
	Random rn;
	GameObject littleAfro;
	// Use this for initialization
	void Start () {
		rn = new Random();


	}
	
	// Update is called once per frame
	void Update () {
		littleAfro = GameObject.CreatePrimitive(PrimitiveType.Cube);

		//littleAfro.transform.position = Vector3 ();
	}
}
