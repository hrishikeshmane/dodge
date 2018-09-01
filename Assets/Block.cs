using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	void Start ()
	{
		GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 30f;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y < -2f)
		{
			Destroy(gameObject);
		}
	}

}