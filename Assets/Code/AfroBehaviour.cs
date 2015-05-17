using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AfroBehaviour : MonoBehaviour {
	public Text scoreText;
	public GameObject[] lives;
	float speed = 300.0f;
	int score;
	int saksiHitCounter;
	public GameObject platform;
	Vector3 rightEdge;
	Vector3 leftEdge;
	Renderer renderer;
	bool onLeftSide;
	bool onRightSide;
	float center;
	float y;

	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
		renderer = GetComponent<SpriteRenderer> ();
		center = platform.transform.position.x;
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


		if (!(renderer.isVisible))
		{
			if(onLeftSide == true)
			{
				teleportToRightEdge();
			}
			else
			{
				teleportToLeftEdge();
			}

		}

		if (transform.position.x < center) {
			onLeftSide = true;
			onRightSide = false;
		}
		else if(transform.position.x >= center)
		{
			onRightSide = true;
			onLeftSide = false;
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

		if (otherObj.gameObject.tag == "AfroClone") {
			Destroy (otherObj.gameObject);
			transform.localScale = transform.localScale + new Vector3 (3f, 3f, 0f);
			score++;
		} else if (otherObj.gameObject.tag == "SaksiClone") {
			saksiHitCounter++;
			Destroy (otherObj.gameObject);
			transform.localScale = transform.localScale - new Vector3 (10f, 10f, 0f);

			transform.localScale = transform.localScale*(-0.70f);
			score--;

			removeLife (saksiHitCounter);
		}

		scoreText.text = "" + score;
	}

	void removeLife(int c)
	{
		if (c < 4)
		{
			Destroy (lives [3 - c]);
		
		} 

		if(c==3)
			endGame ();
	}

	void endGame()
	{
		animator.SetTrigger ("died");
		PlayerPrefs.SetInt ("endScore", score);
		StartCoroutine ("goToScoreScreen");
	}

	IEnumerator goToScoreScreen()
	{
		yield return new WaitForSeconds (2.0f);
		Application.LoadLevel ("End_scene");
	}

	void teleportToRightEdge()
	{
		y = transform.position.y;
		rightEdge = new Vector3 (1150, y, 0);
		transform.position = rightEdge;
	}

	void teleportToLeftEdge()
	{
		y = transform.position.y;
		leftEdge = new Vector3 (0, y, 0);
		transform.position = leftEdge;
	}

}
