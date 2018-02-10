using UnityEngine;
using System.Collections;
/// <summary>
/// Player movement animator.
/// </summary>
public class PlayerMovementAnimator : MonoBehaviour {
	/*
	private Animator _animator;
	private PlayerStatus _state;

	// Use this for initialization
	void Start () {
		//Make ref to the Player Animator;
		_animator = GetComponent<Animator> ();
		//Make a ref to the Player Status Script
		_state = GetComponentInParent<PlayerStatus> ();
	}
	//Fixed Update is called once per Physics step
	void Update(){
		//Animate the Player
		Animate ();
	}

	void Animate(){
		//If the player is "Alive"
		if (_state.getLiveState == 0) {
			//Set the walklayer to the front
			_animator.SetLayerWeight (0,1);
			//Send the lives layer backwards
			_animator.SetLayerWeight (1,0);
			//Give the animator the right values
			_animator.SetInteger ("state", _state.getMovementState);
		}
	}
	*/
}
