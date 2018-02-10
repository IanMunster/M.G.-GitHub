using UnityEngine;
using System.Collections;
/// <summary>
/// Movement handler.
/// </summary>
public class MovementHandler : MonoBehaviour {

	[SerializeField] private float _maxSpeed;
	private Rigidbody _rigid;
	private Vector3 _currentPosition;
	private Vector3 _velocity;
	private Vector3 _direction;

	public Vector3 Direction {
		get { return _direction; }
		set { _direction = value; }
	}

	public Vector3 Velocity{
		get {return _velocity; }
		set {_velocity = value; }
	}
/*
	public void setDirection(Vector3 newDirection){
		_direction = newDirection;
	}

	public Vector3 getDirection{
		get{return _direction;}
	}

	public void setVelocity(Vector3 newVelocity){
		_velocity = newVelocity;
	}

*/
	// Use this for initialization
	void Start () {
		_rigid = GetComponent<Rigidbody> ();
		_velocity = new Vector3 (0,0,0);
		//_currentPosition = transform.position;
	}
	// Update is called once per frame
	void Update () {
		Move ();
	}
	void Move(){
		//Vector3 desiredStep = _direction - _currentPosition;
		//desiredStep.Normalize ();
		//Vector3 desiredVelocity = desiredStep * _maxSpeed;
		//_currentPosition += _velocity * Time.deltaTime;
		//transform.position = _currentPosition;

		_rigid.velocity = _velocity;
	}
}
