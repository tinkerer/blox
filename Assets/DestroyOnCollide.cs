using UnityEngine;
using System.Collections;

public class DestroyOnCollide : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionEnter(Collision other)
	{
		BallComponent bc = other.transform.GetComponent<BallComponent> ();
		Debug.Log ("normal"+other.contacts [0].normal);
		if (Mathf.Abs(other.contacts [0].normal.x) > .5) {
			bc.velocity.Scale (new Vector3(-1,0,1));
		}
		else {
			bc.velocity.Scale (new Vector3(1,0,-1));
		}

		Destroy (gameObject);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
