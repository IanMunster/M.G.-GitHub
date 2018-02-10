using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	private EnemyMovement _movement;
	private EnemyChasing _chase;
	private EnemyPatrolling _patrol;
	private CollisionHandler _collision;

	private HealthHandler _health;
	private TriggerHandler _trigger;
	private EnemyKnockback _knockback;

	private EnemyAnimator _animator;
    

	private Vector3 _newDirection;
	private bool _isChasing;
	private bool _isPatrolling;

	public Vector3 getDirection {
		get { return _newDirection;} 
	}

	// Use this for initialization
	void Start () {
		_movement = GetComponent<EnemyMovement>();
		_chase = GetComponent<EnemyChasing> ();
		_patrol = GetComponent<EnemyPatrolling> ();
		_collision = GetComponent<CollisionHandler> ();

		_health = GetComponent<HealthHandler> ();
		_trigger = GetComponent<TriggerHandler> ();
        _knockback = GetComponent<EnemyKnockback>();
        
		_animator = GetComponent<EnemyAnimator> ();

		_isPatrolling = true;//TEMP
	}
	
	// Update is called once per frame
	void Update () {
		_patrol.setIsPatrolling (_isPatrolling);
        _movement.Move(GetAllDirections());
	}

	Vector3 GetAllDirections(){
     //   if(_knockback.vel.magnitude < 0.1)
        {
            return _patrol.getVelocity + _chase.getVelocity;
        }
     //   return new Vector3(0, 0, 0);
	}

	void CheckHealth (){
		if(_health.getIsDead){
			_movement.Velocity = new Vector3(0f,0f,0f);
			_movement.setSpeed (0);
		}
		if(_trigger.getIsTriggered){
			_health.subtractHealth (1);
		}
	}

	void CheckCollision(){
		//_patrol.NewRandomVemocity();
	}
	void CheckAnimations(){
		if (!_health.getIsDead) {
			_animator.setMoveFloat (_movement.Velocity);
		} else {
			_animator.setIsDead (_health.getIsDead);
		}
	}
 }