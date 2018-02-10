using UnityEngine;
using System.Collections;
/// <summary>
/// Player lives.
/// This class is responsible for the Lives the player has and whether the player is Hurt or Dead
/// Check for Hurt based on the Collider on the Player
/// </summary>
public class PlayerLives : MonoBehaviour {
	/*
	//A ref to the PlayerMovement
	private PlayerMovement _movement;
	//Make a ref to the Player Status Script
	private PlayerStatus _state;
	//The number of lives the Player currently has.
	private float _health;
	//The Maximal number of lives the Player can have;
	[SerializeField] private float _maxHealth;
	//The Tags of Deadly Objects that take a live when Collision occurs
	[SerializeField] private string _DeadlyObjectTag01;
	[SerializeField] private string _DeadlyObjectTag02;
	//Boolean when the player is Hurt
	private bool _isHit = false;
	//Boolean when the player is Dead
	private bool _isDead = false;

	//Gives the current Health as Float(number)
	public float getCurrentHealth {
		get{ return _health; }
	}
	//Gives the Boolean if isHit
	public bool getIsHit {
		get { return _isHit; }
	}
	//Gives the Boolean if isDead
	public bool getIsDead{
		get{return _isDead; }
	}

	// Use this for initialization
	void Start () {
		//At start set the current health to the max health
		_health = _maxHealth;
		//Get the PlayerMovement component
		_movement = GetComponent<PlayerMovement>();
		//Get the Player Status component
		_state = GetComponent<PlayerStatus> ();
	}
	
	// Update is called once per physics step
	void FixedUpdate () {
		//The isDead Boolean depends on the Check if is Dead
		_isDead = CheckDead ();
		//When the player is dead, he can no longer move
		if(_isDead){
			_movement.setCurrentSpeed(0f);
		}
	}

	//Checks if something ("other") triggers the Collider of the player

	void OnCollisionEnter(Collision other){
		//Check if its tag is marked as Deadly Object
		if(other.collider.CompareTag(_DeadlyObjectTag01) || other.collider.CompareTag(_DeadlyObjectTag02)){
			if(_state.getLiveState != 2){
				_state.setLiveState (1);
				_health -= 1;
				_isHit = true;
			}
		}
	}

	//Checks if something ("other") exits the triggers of the player
	void OnCollisionExit(Collision other){
		//Check if its tag is marked as Deadly Objects
		if(other.collider.CompareTag(_DeadlyObjectTag01) || other.collider.CompareTag(_DeadlyObjectTag02)){
			if(_state.getLiveState != 2){
				_state.setLiveState (0);
				_isHit = false;
			}
		}
	}

	bool CheckDead(){
		if(_health <= 0){
			_state.setLiveState (2);
			return true;
		} else if(_health > 0){
			return false;
		} else if(_health > _maxHealth){
			print ("IM A CHEATER");
			_health = _maxHealth;
			return false;
		}
		return true;
	}
	*/
}
