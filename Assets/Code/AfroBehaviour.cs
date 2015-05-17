using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AfroBehaviour : MonoBehaviour {
	public Text scoreText;
	public GameObject[] lives;
	float speed = 300.0f;
	int score;
	int saksiHitCounter;

	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			animator.SetInteger("direction", 0);

			transform.position += Vector3.left * speed * Time.deltaTime;

		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			animator.SetInteger("direction", 1);
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
		transform.position += Vector3.left * speed * Time.deltaTime;

	}

	public void oikealle()
	{
		transform.position += Vector3.right * speed * Time.deltaTime;

	}

	void OnCollisionEnter2D(Collision2D otherObj)
	{
		Debug.Log ("afro hit " + otherObj.gameObject.ToString ());

		if (otherObj.gameObject.tag == "AfroClone") {
			Destroy (otherObj.gameObject);
			transform.localScale = transform.localScale + new Vector3 (5f, 5f, 0f);
			score++;
		} else if (otherObj.gameObject.tag == "SaksiClone") {
			Destroy (otherObj.gameObject);
			transform.localScale = transform.localScale - new Vector3 (20f, 20f, 0f);
			score--;
			saksiHitCounter++;
			removeLife (saksiHitCounter);
		}

		scoreText.text = "" + score;
	}

	void removeLife(int c)
	{
		if (c < 4)
		{
			Destroy (lives [c - 1]);
		
		} 

		if(c==3)
			endGame ();
	}

	void endGame()
	{
		PlayerPrefs.SetInt ("endScore", score);
		Application.LoadLevel ("End_scene");
	}

}
