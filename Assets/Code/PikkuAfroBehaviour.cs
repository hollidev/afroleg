using UnityEngine;
using System.Collections;

public class PikkuAfroBehaviour : MonoBehaviour {

	public Transform littleAfro;
	public GameObject platform;
	int updateCounter = 0;
	float scale;
	Rigidbody2D rb;
	float force;

	float pos;

	void Start () {
		scale = platform.transform.localScale.x;


	}
	
	// Update is called once per frame
	void Update () {
		updateCounter ++;
		
		if (updateCounter % 100 == 0) {
			Transform obj = Instantiate(littleAfro);
			GameObject afroClone = obj.gameObject;
			littleAfro.tag = "AfroClone";
			rb = afroClone.GetComponent<Rigidbody2D>();
			force = Random.Range (1000f,20000f);
			rb.AddForce(Vector3.down * force);
			pos = Random.Range (0, scale);
			littleAfro.transform.position = new Vector3 (pos,568f);



			Debug.Log ("afroclone created");
		}


	}

	
}
