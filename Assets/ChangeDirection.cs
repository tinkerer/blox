using UnityEngine;
using System.Collections;

public class ChangeDirection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public bool zAxis = true;
	public bool xAxis = false;
	void OnCollisionEnter(Collision other)
	{
		BallComponent bc = other.transform.GetComponent<BallComponent> ();
		if (zAxis){ bc.velocity.Scale (new Vector3 (1,0,-1));}
		if (xAxis){ bc.velocity.Scale (new Vector3 (-1,0,1));}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
