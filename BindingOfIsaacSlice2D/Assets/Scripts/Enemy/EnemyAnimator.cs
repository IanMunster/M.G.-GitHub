using UnityEngine;
using System.Collections;

public class EnemyAnimator : MonoBehaviour {

	private Animator _animator;				//Make a reference to the Animator Component
	private float _animateX;				//Private var for X input
	private float _animateY;				//Private var for Y input

	private bool _isDead;

	public void setMoveFloat(Vector3 newMovement){	//Set new values to Animator
		_animateX = newMovement.x;						//Set X to new X
		_animateY = newMovement.y;						//Set Y to new Y
	}
	public void setIsDead(bool newIsDead){
		_isDead = newIsDead;
	}

	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator> ();					//Find the Animator Component
	}

	// Update is called once per frame
	void Update () {
		_animator.SetBool ("isDead",_isDead);

		_animator.SetFloat ("moveX",_animateX);		//Give the Animator the X value
		_animator.SetFloat ("moveY",_animateY);		//Give the Animator the Y value
	}
}
