using UnityEngine;
using System.Collections;

public class HealthAnimator : MonoBehaviour {

	private Animator _animator;
	private HealthHandler _health;
	private bool _animateHurt;
	private bool _animateDead;

	public void setAnimatorHurt(bool newHurt){
		_animateHurt = newHurt;
	}
	public void setAnimatorDead(bool newDead){
		_animateDead = newDead;
	}

	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator> ();
		_health = GetComponentInParent<HealthHandler> ();
	}

	// Update is called once per frame
	void Update () {
		if(_health != null){
			//_animateHurt = _health.getIsHurt;
			_animateDead = _health.getIsDead;
		}
		//_animator.SetFloat ("directionX",_animateHurt);
		//_animator.SetFloat ("directionY",_animateDead);
	}
}
