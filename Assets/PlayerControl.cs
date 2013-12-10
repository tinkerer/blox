using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public float fastMove = 0.5f;
	public float slowMove = 0.1f;
	public float maxX = 25f;
	public float minX = -25f;
	// Update is called once per frame


	void FixedUpdate () {
		bool doMove = false;

		if (transform.position.x > maxX) {
			if (Input.GetAxis ("Horizontal") < 0) {
				doMove = true;
				}
			}	
		else if (transform.position.x < minX) {
			if (Input.GetAxis ("Horizontal") > 0) {
				doMove = true;
				}	
			}
		else {
			doMove = true;
		}

		if (doMove) {
						float moveRate = (Input.GetAxis ("Run") > .5f) ? fastMove : slowMove;
						transform.position = transform.position + new Vector3 (Input.GetAxis ("Horizontal") * moveRate, 0, 0);
				}
	}
}
