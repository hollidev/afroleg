using UnityEngine;
using System.Collections;

public class PikkuAfroBehaviour : MonoBehaviour {

	public Transform littleAfro;
	public GameObject platform;
	int updateCounter = 0;
	float scale;
	float collisionTime = 0f;
	float fallSpeed = 0f;

	float pos;

	void Start () {
		scale = platform.transform.localScale.x;

	}
	
	// Update is called once per frame
	void Update () {
		updateCounter ++;
		
		if (updateCounter % 100 == 0) {
			Instantiate(littleAfro);
			littleAfro.tag = "AfroClone";
			pos = Random.Range (0, scale);
			littleAfro.transform.position = new Vector3 (pos,568f);
			//enableGravity(littleAfro);
			fallSpeed = Random.Range (1f, 10f);
			Debug.Log ("afroclone created");
		}
	}

	void enableGravity(Transform afro)
	{
		Rigidbody2D rb = afro.GetComponent<Rigidbody2D> ();
		//rb.useGravity = true;
	}
	
}
