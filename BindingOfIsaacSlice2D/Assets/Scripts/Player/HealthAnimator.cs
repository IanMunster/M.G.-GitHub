using UnityEngine;
using System.Collections;
/// <summary>
/// Health animator.
/// This Class is responsible for all the Health Animations: When is hit and when is Dead
/// </summary>
public class HealthAnimator : MonoBehaviour {

	private Animator _animator;							//Make a reference to the AnimatorComponent
	private bool _animateHurt;							//Boolean when is Hurt
	private bool _animateDead;							//Boolean when is Dead

	public void setAnimatorHurt(bool newHurt){			//Set the Hurt Boolean to the new Hurt value
		_animateHurt = newHurt;							//Give Hurt the New Hurt value
	}
	public void setAnimatorDead(bool newDead){			//Set the Dead Boolean to the new Dead value
		_animateDead = newDead;							//Give Dead the New Dead value
	}

	// Use this for initialization
	void Start () {											//On start of the Game
		_animator = GetComponent<Animator> ();				//Get the Animator Component
	}

	// Update is called once per frame
	void Update () {
		if(_animateDead){
			_animator.SetBool ("isDead",_animateDead);
		}
		if(_animateHurt){
			_animator.SetTrigger ("hurt");
		}
	}
}
