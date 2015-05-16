using UnityEngine;
using System.Collections;

public class testikapsulibehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.right * 30.0f * Time.deltaTime;
	}
}
