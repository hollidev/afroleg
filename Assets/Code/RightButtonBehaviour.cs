using UnityEngine;
using System.Collections;

public class RightButtonBehaviour : MonoBehaviour {
	public GameObject afro;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			afro.transform.position += Vector3.right * 200f * Time.deltaTime;
			Debug.Log ("Mouse pressed");
		}

	}


}
