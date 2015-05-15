using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		SetTransformX(7.0f);
	}

	void SetTransformX(float n){
		transform.position = new Vector3(n, transform.position.y, transform.position.z);
	}


}
