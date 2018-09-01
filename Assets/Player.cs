using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	public float speed = 30f;
	public float mapWidth = 1.8f;

	private Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate ()
	{
		float x = CrossPlatformInputManager.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
		//rb.MovePosition (rb.position + Vector2.right * x);
		Vector2 newPosition = rb.position + Vector2.right * x;

		newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

		rb.MovePosition(newPosition);

	}

	void OnCollisionEnter2D ()
	{
		FindObjectOfType<GameManager>().EndGame();
	}

}
