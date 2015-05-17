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
		for (int i = 0; i < Input.touchCount; ++i) {
			//if (Input.GetTouch(i).phase == TouchPhase.Began)
			afro.transform.position += Vector3.left * 300f * Time.deltaTime;
		}
	}


}
