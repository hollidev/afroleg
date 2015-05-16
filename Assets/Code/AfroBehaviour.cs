using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AfroBehaviour : MonoBehaviour {
	public Text scoreText;
	float speed = 200.0f;
	int score;
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
			//transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			//transform.position += Vector3.down * speed * Time.deltaTime;
		}

	}

	public void vasemmalle()
	{

	}

	public void oikealle()
	{

	}

	void OnCollisionEnter2D(Collision2D otherObj)
	{
		Debug.Log ("afro hit " + otherObj.gameObject.ToString ());

		if (otherObj.gameObject.tag == "AfroClone") {
			Destroy (otherObj.gameObject);
			transform.localScale = transform.localScale + new Vector3 (5f, 5f, 0f);
			score++;
			PlayerPrefs.SetInt("gameScore", score);
		} else if (otherObj.gameObject.tag == "SaksiClone") {
			Destroy (otherObj.gameObject);
			transform.localScale = transform.localScale - new Vector3 (20f, 20f, 0f);
			score--;
			PlayerPrefs.SetInt("gameScore", score);
		}

		scoreText.text = "" + score;
	}


}
