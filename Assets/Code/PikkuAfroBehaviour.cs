using UnityEngine;
using System.Collections;

public class PikkuAfroBehaviour : MonoBehaviour {

	public Transform littleAfro;
	public GameObject platform;
	int updateCounter = 0;
	float scale;
	float collisionTime = 0f;
	float fallSpeed = 0f;
	Vector3 down;

	float pos;

	void Start () {
		scale = platform.transform.localScale.x;
		down = Vector3.down;

	}
	
	// Update is called once per frame
	void Update () {
		updateCounter ++;
		
		if (updateCounter % 200 == 0) {
			Instantiate(littleAfro);
			littleAfro.tag = "AfroClone";
			pos = Random.Range (0, scale);
			littleAfro.transform.position = new Vector3 (pos,568f);
			Rigidbody rb = littleAfro.GetComponent<Rigidbody>();
			fallSpeed = Random.Range (10f, 100f);


			Debug.Log ("afroclone created");
		}


	}

	void enableGravity(Transform afro)
	{
		Rigidbody2D rb = afro.GetComponent<Rigidbody2D> ();
		//rb.useGravity = true;
	}
	
}
