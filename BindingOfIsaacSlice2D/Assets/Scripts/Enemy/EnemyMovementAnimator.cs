using UnityEngine;
using System.Collections;
/// <summary>
/// Enemy animator.
/// </summary>
public class EnemyMovementAnimator : MonoBehaviour {

	private Animator _animator;
	private EnemyMovement _movement;
	private int _animationState = 0;

	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator> ();
		_movement = GetComponent<EnemyMovement> ();
	}
	//Fixed Update is called once per Physics step
	void FixedUpdate(){
		CheckVelocity ();
		Animate ();
	}
		
	void CheckVelocity(){
		if(_movement.Velocity.y > 0 && _movement.Velocity.y > (_movement.Velocity.x+0.5)){
			_animationState = 1;
		} else if(_movement.Velocity.y < 0 && _movement.Velocity.y < (_movement.Velocity.x+0.5)){
			_animationState = 2;
		} else if(_movement.Velocity.x > 0 && _movement.Velocity.x > _movement.Velocity.y){
			_animationState = 3; 
		} else if(_movement.Velocity.x < 0 && _movement.Velocity.x < _movement.Velocity.y){
			_animationState = 4;
		} else {
			_animationState = 0;
		}
	}

	void Animate(){
		_animator.SetInteger ("state",_animationState);
	}
}
