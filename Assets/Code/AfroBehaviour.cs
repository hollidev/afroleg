using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AfroBehaviour : MonoBehaviour {
	public Text scoreText;
	public GameObject[] lives;
	float speed = 300.0f;
	int score;
	int saksiHitCounter = 0;
	public GameObject platform;
	Vector3 rightEdge;
	Vector3 leftEdge;
	Renderer renderer;
	bool onLeftSide;
	bool onRightSide;
	float center;
	float y;
	int growCounter = 0;
	int currentLives = 3;
	Vector3 originalScale;
	bool inAir = false;

	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
		renderer = GetComponent<SpriteRenderer> ();
		center = platform.transform.position.x;
		originalScale = transform.localScale;
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

			jump();
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

	void jump()
	{
		if (inAir == false) {
			inAir = true;
			GetComponent<Rigidbody2D> ().AddForce (Vector3.up * 15000f);
		}

	}
	
	public void vasemmalle()
	{
		transform.position += Vector3.left * speed * Time.deltaTime;

	}

	public void oikealle()
	{
		//transform.position += Vector3.right * speed * Time.deltaTime;

	}

	void OnCollisionEnter2D(Collision2D otherObj)
	{

		if (otherObj.gameObject.tag == "AfroClone") {
			Destroy (otherObj.gameObject);

			growCounter++;

			if (growCounter < 15)
				transform.localScale = transform.localScale + new Vector3 (3f, 3f, 0f);
			else if (growCounter == 15 && currentLives < 3) {
				addLife ();
				growCounter = 0;

			}


			score++;
		} else if (otherObj.gameObject.tag == "SaksiClone") {
			currentLives--;
			transform.localScale = transform.localScale - new Vector3 (5f, 5f, 0f);
			Destroy (otherObj.gameObject);

			removeLife (currentLives);
		} else if (otherObj.gameObject.tag == "platform")
			inAir = false;

		scoreText.text = "" + score;


	}

	void removeLife(int nOfLives)
	{
		if (nOfLives < 3)
		{
			lives [nOfLives].SetActive(false);
			growCounter = 0;
			transform.localScale = originalScale;
			updateAnimatorLives (currentLives);
		} 

		if(nOfLives==0)
			endGame ();
	}

	void addLife()
	{
		currentLives++;
		lives [currentLives-1].SetActive(true);
		updateAnimatorLives (currentLives);

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
		rightEdge = new Vector3 (1147, y, 0);
		transform.position = rightEdge;
	}

	void teleportToLeftEdge()
	{
		y = transform.position.y;
		leftEdge = new Vector3 (0, y, 0);
		transform.position = leftEdge;
	}

	void updateAnimatorLives(int n)
	{
		animator.SetInteger("lives", n);
	}

}
