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
		if(_movement.getVelocity.y > 0 && _movement.getVelocity.y > (_movement.getVelocity.x+0.5)){
			_animationState = 1;
		} else if(_movement.getVelocity.y < 0 && _movement.getVelocity.y < (_movement.getVelocity.x+0.5)){
			_animationState = 2;
		} else if(_movement.getVelocity.x > 0 && _movement.getVelocity.x > _movement.getVelocity.y){
			_animationState = 3; 
		} else if(_movement.getVelocity.x < 0 && _movement.getVelocity.x < _movement.getVelocity.y){
			_animationState = 4;
		} else {
			_animationState = 0;
		}
	}

	void Animate(){
		_animator.SetInteger ("state",_animationState);
	}
}
