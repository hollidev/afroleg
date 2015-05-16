using UnityEngine;
using System.Collections;

public class LeftButtonBehaviour : MonoBehaviour {
	public GameObject afro;
	// Use this for initialization
	void Start () {
		//todo GUI.RepeatButton
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
			afro.transform.position += Vector3.left * 200f * Time.deltaTime;
		
	}


}
