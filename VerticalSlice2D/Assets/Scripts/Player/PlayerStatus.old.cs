using UnityEngine;
using System.Collections;
/// <summary>
/// Player status.
/// Check input and set the Status;
/// Movement and Looking: 1=Up; 2=Right; 3=Down; 4=Left; 
/// Shooting: True or False;
/// </summary>
public class PlayerStatus : MonoBehaviour {
	/*
	private InputHandler _input;

	private int _moveState;
	private int _lastMoveState;
	private int _lookState;
	private bool _isShooting;
	private int _liveState;

	public int getMovementState{
		get{ return _moveState; }
	}
	public int getLookState{
		get{ return _lookState; }
	}
	public bool getShootState{
		get{ return _isShooting; }
	}

	public void setLiveState(int _newState){
		_liveState = _newState;
	}
	public int getLiveState {
		get{ return _liveState; }
	}

	// Use this for initialization
	void Start () {
		_input = GameObject.FindGameObjectWithTag ("GameController").GetComponent<InputHandler> ();
	}
	
	// Update is called once per frame
	void Update () {
		CheckForInput();
	}

	void CheckForInput(){

		int _tempMoveState = _moveState;
		if(_tempMoveState != 0){
			_lastMoveState = _tempMoveState;
		}
		if(_input.moveVertical == 0 && _input.moveHorizontal == 0){
			_tempMoveState = 0;
		}
		if(_input.moveVertical > 0){
			_tempMoveState = 1;
		}
		if(_input.moveHorizontal > 0){
			_tempMoveState = 2;
		}
		if(_input.moveVertical < 0){
			_tempMoveState = 3;
		}
		if(_input.moveHorizontal < 0){
			_tempMoveState = 4;
		}
		_moveState = _tempMoveState;

		int _tempLookState = _lookState;
		if(_input.lookVertical == 0 && _input.lookHorizontal == 0){
			_tempLookState = _moveState;
		}
		if(_input.lookVertical > 0){
			_tempLookState = 1;
		}
		if(_input.lookHorizontal > 0){
			_tempLookState = 2;
		}
		if(_input.lookVertical < 0){
			_tempLookState = 3;
		}
		if(_input.lookHorizontal < 0){
			_tempLookState = 4;
		}
		_lookState = _tempLookState;
	}
	*/
}
