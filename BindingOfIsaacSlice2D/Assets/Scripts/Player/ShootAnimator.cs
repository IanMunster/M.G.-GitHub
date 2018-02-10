using UnityEngine;
using System.Collections;

public class ShootAnimator : MonoBehaviour {

	private Animator _animator;				//A reference to the Animator Component
	private WeaponsInputProcessor _shoot;	//A reference to the ShootHandler
	private MovementHandler _move;
	private float _animateX;				//private variable for X-axis Input
	private float _animateY;				//private variable for Y-axis Input

	public void setAnimatorFloat(Vector3 newShoot){
		_animateX = newShoot.x;
		_animateY = newShoot.y;
	}

	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator> ();
		_shoot = GetComponentInChildren<WeaponsInputProcessor> ();
		_move = GetComponentInParent<MovementHandler> ();
	}

	// Update is called once per frame
	void Update () {
		if (_shoot.shootDirection.x == 0 && _shoot.shootDirection.y == 0) {
			_animateX = _move.Velocity.x;
			_animateY = _move.Velocity.y;

			_animator.SetBool ("isShooting",false);
		} else {
			_animateX = _shoot.shootDirection.x;
			_animateY = _shoot.shootDirection.y;

			_animator.SetBool ("isShooting",true);
			//_animator.SetTrigger ("shot");
		}

		_animator.SetFloat ("directionX",_animateX);
		_animator.SetFloat ("directionY",_animateY);
	}
}
