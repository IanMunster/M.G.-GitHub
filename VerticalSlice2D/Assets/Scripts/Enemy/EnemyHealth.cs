using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	//A ref to the Enemy Movement
	private EnemyMovement _movement;
	//The Current Health of the Enemy
	private float _health;
	//The maximal number of lives the Enemy can have.
	[SerializeField] private float _maxHealth;
	//The Tags of Deadly Objects that take a live when Collision occurs
	[SerializeField] private string _DeadlyObjectTag01;
	[SerializeField] private string _DeadlyObjectTag02;
	//Boolean when the enemy is Hurt
	private bool _isHit = false;
	//Boolean when the enemy is Dead
	private bool _isDead = false;
	private SpriteRenderer _render;
	private Color _normalColor;

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
		//Get the EnemyMovement component
		_movement = GetComponent<EnemyMovement>();
		_render = GetComponent<SpriteRenderer> ();
		_normalColor = _render.color;
	}
	
	// Update is called once per physics step
	void FixedUpdate () {
		//The isDead Boolean depends on the Check if is Dead
		_isDead = CheckDead ();
		//When the player is dead, he can no longer move
		if(_isDead){
			_movement.setSpeed(0f);
		}
	}

	//Checks if something ("other") triggers the Collider of the Enemy
	void OnCollisionEnter(Collision other){
		//Check if its tag is marked as Deadly Object
		if(other.collider.CompareTag(_DeadlyObjectTag01) || other.collider.CompareTag(_DeadlyObjectTag02)){
			_render.color = new Color (1,0,0);
			//If so then Enemy takes a Hit
			_isHit = true;
			//And health is reduced by 1
			_health -= 1;
		}
		//If something else triggers the Collider, don't register it as a Hit
		_isHit = false;
		_render.color = _normalColor;
	}

	bool CheckDead(){
		if(_health <= 0){
			return true;
		} else if(_health > 0){
			return false;
		} else if(_health > 3){
			print ("IM A CHEATER");
			_health = _maxHealth;
			return false;
		}
		return true;
	}
}
