using UnityEngine;
using System.Collections;
/// <summary>
/// Player State handler.
/// </summary>
public class PlayerStateHandler : MonoBehaviour {

	private InputHandler _input;

	private HealthHandler _health;
	private MovementHandler _move;
	private ShootHandler _shoot;
	private CollisionHandler _collision;

	private bool _deadState;
	private int _healthState;

	// Use this for initialization
	void Start () {
		_input = GameObject.Find("GameController").GetComponent<InputHandler> ();
		_health = GetComponent<HealthHandler> ();
		_move = GetComponent<MovementHandler> ();
		_shoot = GetComponent<ShootHandler> ();
		_collision = GetComponent<CollisionHandler> ();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateHealthState ();
		UpdateMoveState ();
		UpdateShootState ();
		UpdateCollideState ();
	}

	void UpdateHealthState(){
		_healthState = _health.getCurrentHealth;
		_deadState = _health.getIsDead;

		print ("PLAYER HEALTH: "+_healthState);
	}
	void UpdateMoveState(){
		_move.Velocity = new Vector3 (_input.moveHorizontal, _input.moveVertical, 0f);
	}
	void UpdateShootState(){
		_shoot.setShootDirection (new Vector3(_input.lookHorizontal, _input.lookVertical, 0f));
	}
	void UpdateCollideState(){
		GameObject other = _collision.getCollidingGameobject;
		string[] tags = _collision.getColliderTags;

		if(other != null){
			for (int i = 0; i < tags.Length; i++) {
				if(other.tag == tags[i]){
					//start Health coroutine?
					print ("Collision With: "+other.tag);
				}
			}
		}

	}
}
