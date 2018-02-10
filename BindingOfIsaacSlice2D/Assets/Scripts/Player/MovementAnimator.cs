using UnityEngine;
using System.Collections;
/// <summary>
/// Movement animator.
/// This Class is responible for all the Movement Animations
/// </summary>
public class MovementAnimator : MonoBehaviour {

	private Animator _animator;				//Make a reference to the Animator Component
	private MovementHandler _movement;		//Make a reference to the Movement Script
	private float _animateX;				//Private var for X input
	private float _animateY;				//Private var for Y input

	public void setAnimatorFloat(Vector3 newMovement){	//Set new values to Animator
		_animateX = newMovement.x;						//Set X to new X
		_animateY = newMovement.y;						//Set Y to new Y
	}

	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator> ();					//Find the Animator Component
		_movement = GetComponentInParent<MovementHandler> ();	//Find the Movement Script
	}
	
	// Update is called once per frame
	void Update () {
		if(_movement != null){						//If movement is not Null
			_animateX = _movement.Velocity.x;		//Set X to the Velocity on X axis of the Movement
			_animateY = _movement.Velocity.y;		//Set Y to the Velocity on Y axis of the Movement
		}
		_animator.SetFloat ("moveX",_animateX);		//Give the Animator the X value
		_animator.SetFloat ("moveY",_animateY);		//Give the Animator the Y value
	}
}
