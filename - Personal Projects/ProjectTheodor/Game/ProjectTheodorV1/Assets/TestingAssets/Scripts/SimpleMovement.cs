using UnityEngine;
using System.Collections;

public class SimpleMovement : MonoBehaviour {

	private float _mySpeed = 10f;
	private Rigidbody _myRigidbody;

	// Use this for initialization
	void Start () {
		_myRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		_myRigidbody.velocity = new Vector3(Input.GetAxis ("Horizontal")*_mySpeed, Input.GetAxis ("Vertical")*_mySpeed,0f);
	}
}
