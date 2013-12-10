using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public float xOffsetScale = 0.2f;
	public float velScale = 0.2f;
	public float maxRatio = 1.5f;
	void OnCollisionEnter(Collision other)
	{
		BallComponent bc = other.transform.GetComponent<BallComponent> ();
		float dx = transform.position.x - other.transform.position.x;
		Debug.Log("dx"+dx);
		bc.velocity.Scale (new Vector3 (0, 0, -1));
		bc.velocity.x = -dx*xOffsetScale;

		if (Mathf.Abs (bc.velocity.x) > (Mathf.Abs (bc.velocity.z) * maxRatio)) {
			bc.velocity = new Vector3(maxRatio*Mathf.Sign(bc.velocity.x), 0, Mathf.Sign(bc.velocity.z));
		}

		bc.velocity.Normalize ();
		bc.velocity *= velScale;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
