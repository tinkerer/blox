using UnityEngine;
using System.Collections;

public class BallComponent : MonoBehaviour {
	public Vector3 velocity;
	// Use this for initialization
	void Start () {
		}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LateUpdate()
	{
		transform.position += velocity;
	}
}
