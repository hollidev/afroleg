using UnityEngine;
using System.Collections;

public class PlatformScript : MonoBehaviour {

	GameObject littleAfro;
	int updateCounter = 0;
	float scale;
	float collisionTime = 0f;
	float fallSpeed = 0f;
	int afroCounter;
	float pos;

	
	// Use this for initialization
	void Start () {
		scale = transform.localScale.x;
		littleAfro = GameObject.CreatePrimitive (PrimitiveType.Cube);
		Rigidbody rb = littleAfro.AddComponent<Rigidbody>();
		rb.useGravity = false;
		rb.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;

	}
	
	// Update is called once per frame
	void Update () {
		updateCounter ++;

		if (updateCounter % 100 == 0) {
			Instantiate(littleAfro);
			afroCounter++;
			pos = Random.Range (scale/2*(-1), scale/2);
			littleAfro.transform.position = new Vector3 (pos,30f);
			fallSpeed = Random.Range (1f, 10f);

		}
		//GameObject lilAfro = GameObject.FindGameObjectWithTag ("afro1");
		//lilAfro.transform.position += Vector3.down * 5.0f * Time.deltaTime;
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name != "pallo" && col.gameObject != "laattia") {
			Destroy(gameObject,.5f);
		}
	}


}
