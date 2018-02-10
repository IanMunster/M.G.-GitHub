using UnityEngine;
using System.Collections;
/// <summary>
/// Player State handler.
/// This Class is responsible for the connection between the needed components and giving them their values
/// </summary>
public class PlayerStateHandler : MonoBehaviour {

	private InputHandler _input;					//A reference to the InputHandler
	private HealthHandler _health;					//A reference to the HealthHandler
	private HealthAnimator _healthAnimator;
	private MovementHandler _move;					//A reference to the MovementHandler
	private WeaponsInputProcessor _shoot;			//A reference to the ShootHandler
	private TriggerHandler _trigger;			//A reference to the TriggerHandler
	private CollisionHandler _collision;

	private bool _deadState;						//Private boolean for when is dead
	private int _healthState;						//Private int for current health
	private bool _hurtState;
	private Vector3 _velocityState;					//Private Vector3 for the current Velocity


	// Use this for initialization
	void Start () {
		_input = GameObject.Find("GameController").GetComponent<InputHandler> ();	//Find the GameControllers InputHandler
		_health = GetComponent<HealthHandler> ();									//Find the HealthHandler
		_healthAnimator = GetComponent<HealthAnimator>();
		_move = GetComponent<MovementHandler> ();									//Find the MovementHandler
		_shoot = GetComponentInChildren<WeaponsInputProcessor> ();					//Find the ShootHandler
		_trigger = GetComponent<TriggerHandler> ();								//Find the TriggerHandler
		_collision = GetComponent<CollisionHandler>();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateHealthState ();				//Continue to check Health
		UpdateMoveState ();					//Continue to check Movement Input
		UpdateShootState ();				//Continue to check Shoot Input
		UpdateCollideState ();				//Continue to check Trigger
	}

	void UpdateHealthState(){
		_healthState = _health.getCurrentHealth;		//Set the healthState to the CurrentHealth
		_deadState = _health.getIsDead;					//Set the Deadstate to the isDead boolean


		_healthAnimator.setAnimatorDead (_deadState);
		_healthAnimator.setAnimatorHurt (_hurtState);
	}

	void UpdateMoveState(){
		_velocityState = new Vector3 (_input.moveHorizontal, _input.moveVertical, 0f);	//Set the Current Velocity to the Input
		_move.Velocity = _velocityState;												//Give this velocity to the MovementHandler
	}
	void UpdateShootState(){
        Vector3 shootDirection;
        shootDirection = new Vector3(_input.lookHorizontal, _input.lookVertical, 0f);
        _shoot.setShooting(shootDirection);
    }
	void UpdateCollideState(){
		GameObject enemy = _collision.getCollidingGameobject; 	//Get the current Colliding GameObject
		GameObject bullet = _trigger.getTriggeringGameobject;
		if(enemy != null || bullet != null){										//If there is a Current Colliding Gameobject
			//Health Subtract
			_hurtState = true;
		}
		_hurtState = false;

	}
}
