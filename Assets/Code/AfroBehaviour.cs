using UnityEngine;
using System.Collections;

public class AfroBehaviour : MonoBehaviour {

	float speed = 100.0f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;

		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += Vector3.down * speed * Time.deltaTime;
		}

	}

	public void vasemmalle()
	{

	}

	public void oikealle()
	{

	}

	void OnCollisionEnter(Collision otherObj)
	{
		Debug.Log ("afro hit " + otherObj.gameObject.ToString ());

		if (otherObj.gameObject.tag == "AfroClone") {
			Destroy (otherObj.gameObject);
			transform.localScale = transform.localScale+ new Vector3(5f,5f,0f);
		}
	}


}
