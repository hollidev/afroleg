using UnityEngine;
using System.Collections;

public class PikkuAfroBehaviour : MonoBehaviour {

	public Transform littleAfro;
	public GameObject platform;
	int updateCounter = 0;
	float scale;
	float collisionTime = 0f;
	float fallSpeed = 0f;
	int afroCounter;
	float pos;

	void Start () {
		scale = platform.transform.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {
		updateCounter ++;
		
		if (updateCounter % 100 == 0) {
			Instantiate(littleAfro);
			afroCounter++;
			pos = Random.Range (scale/2*(-1), scale/2);
			littleAfro.transform.position = new Vector3 (pos,568f);
			//enableGravity(littleAfro);
			fallSpeed = Random.Range (1f, 10f);
			
		}
	}

	void enableGravity(Transform afro)
	{
		Rigidbody2D rb = afro.GetComponent<Rigidbody2D> ();
		//rb.useGravity = true;
	}

	void OnCollisionEnter(Collision otherObj)
	{
		Debug.Log (otherObj.ToString() + " hit");
		Destroy (littleAfro, 1f);
	}

	void OnCollisionEnter2D(Collision2D otherObj)
	{
		Debug.Log (otherObj.ToString() + " hit");
		Destroy (littleAfro, 1f);
	}
}
