using UnityEngine;
using System.Collections;

public class ShootAnimator : MonoBehaviour {

	private Animator _animator;
	private ShootHandler _shoot;
	private float _animateX;
	private float _animateY;

	public void setAnimatorFloat(Vector3 newShoot){
		_animateX = newShoot.x;
		_animateY = newShoot.y;
	}

	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator> ();
		_shoot = GetComponentInParent<ShootHandler> ();
	}

	// Update is called once per frame
	void Update () {
		if(_shoot != null){
			_animateX = _shoot.Direction.x;
			_animateY = _shoot.Direction.y;
		}
		_animator.SetFloat ("directionX",_animateX);
		_animator.SetFloat ("directionY",_animateY);
	}
}
