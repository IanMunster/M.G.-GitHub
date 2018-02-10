using UnityEngine;
using System.Collections;
/// <summary>
/// Movement handler.
/// This Class is responsible for moving the GameObject
/// </summary>
public class MovementHandler : MonoBehaviour {

	[SerializeField] private float _maxSpeed;		//Total Maximum Speed
	private Rigidbody _rigid;						//The Rigidbody Component
	private Vector3 _currentPosition;				//The Current Position
	private Vector3 _velocity;						//The Current Velocity
	private Vector3 _direction;						//The Current Direction

	public Vector3 Direction {						//Public Direction Property
		get { return _direction; }					//Get the current Direction
		set { _direction = value; }					//Set a new Direction
	}

	public Vector3 Velocity{						//Public Velocity Property
		get {return _velocity; }					//Get the current Velocity
		set {_velocity = value; }					//Set a new Velocity
	}

	// Use this for initialization
	void Start () {
		_rigid = GetComponent<Rigidbody> ();				//Get the Rigidbody Component
		_velocity = new Vector3 (0,0,0);					//Set the Velocity to zero
		//_currentPosition = transform.position;
	}
	// Update is called once per frame
	void Update () { //Move the GameObject
		_rigid.velocity = _velocity;						//Set the velocity to the Velocity											
	}
}
