using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	//A ref to the Enemy Movement
	private EnemyMovement _movement;
	//The Current Health of the Enemy
	private float _health;
	//The maximal number of lives the Enemy can have.
	[SerializeField] private float _maxHealth;
	//The Tag of Deadly Objects that take a live when Collision occurs
	[SerializeField] private string _DeadlyObjectTag01;
	//Boolean when the enemy is Hurt
	private bool _isHit = false;
	//Boolean when the enemy is Dead
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
		//At start set the Health to the MaxHealth
		_health = _maxHealth;
	}
	
	// Update is called once per physics step
	void FixedUpdate () {
		//The isDead Boolean depends on the Check if is Dead
		_isDead = CheckDead ();
	}

	bool CheckDead(){
		if(_health <= 0){
			return true;
		} else if(_health > 0){
			return false;
		} else if(_health > 3){
			_health = _maxHealth;
			return false;
		}
		return true;
	}
}
