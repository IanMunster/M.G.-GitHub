using UnityEngine;
using System.Collections;
/// <summary>
/// Player movement.
/// This script is resposible for all the Player Movement (Vertical and Horizontal)
/// </summary>
public class PlayerMovement : MonoBehaviour {
	/*
	//ref to the input handler for movement
	private InputHandler _input;
	//the rigidbody attatched to the player
	private Rigidbody _rigidbody;
	//the speed with wich the player moves
	[SerializeField] private float _speed;

	public float getCurrentSpeed {
		get{ float _currentSpeed = _speed;
			 return _currentSpeed; }
	}

	public Vector3 getVelocity {
		get{return _rigidbody.velocity; }
	}

	public float setCurrentSpeed (float _newSpeed){
		return _speed = _newSpeed;
	}

	// Use this for initialization
	void Start () {
		//Get the InputHandler component in the GameController object
		_input = GameObject.FindGameObjectWithTag ("GameController").GetComponent<InputHandler> ();
		if(_input == null){
			print ("NO GAME CONTROLLER DETECTED");
		}
		//Get the rigidbody component in player object
		_rigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per physics step
	void FixedUpdate () {
		//add velocity to the player, creating movement in horizontal and vertical direction
		if (_speed != 0) {
			_rigidbody.velocity = new Vector3 (_input.moveHorizontal * _speed, _input.moveVertical * _speed, 0f);
		} else {
			_rigidbody.velocity = new Vector3 (0f,0f,0f);
		}

	}
	*/
}