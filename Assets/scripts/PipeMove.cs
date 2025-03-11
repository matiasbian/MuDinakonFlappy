using UnityEngine;
using System.Collections;

public class PipeMove : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {
		Rigidbody2D body = transform.GetComponent<Rigidbody2D>();
		body.velocity = new Vector2(moveSpeed, 0);
	}

	private void OnEnable()
	{
		GameManager.Instance.EventGameOver += GameOver;
	}

	private void OnDisable()
	{
		if (GameManager.Instance != null)
			GameManager.Instance.EventGameOver -= GameOver;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x <= -0.4) 
		{
			Destroy(gameObject);
		}
	}

	public void GameOver()
	{
		Rigidbody2D body = transform.GetComponent<Rigidbody2D>();
		body.velocity = new Vector2(0, 0);
	}
}
