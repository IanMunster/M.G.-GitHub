using UnityEngine;
using System.Collections;

public class MovementAnimator : MonoBehaviour {

	private Animator _animator;
	private MovementHandler _movement;
	private float _animateX;
	private float _animateY;

	public void setAnimatorFloat(Vector3 newMovement){
		_animateX = newMovement.x;
		_animateY = newMovement.y;
	}

	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator> ();
		_movement = GetComponentInParent<MovementHandler> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(_movement != null){
			_animateX = _movement.Velocity.x;
			_animateY = _movement.Velocity.y;
		}
		_animator.SetFloat ("moveX",_animateX);
		_animator.SetFloat ("moveY",_animateY);
	}
}
