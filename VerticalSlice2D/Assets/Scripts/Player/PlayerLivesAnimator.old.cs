using UnityEngine;
using System.Collections;
/// <summary>
/// Player lives animator.
/// Animates the Player when gotHit and when Dead.
/// Also removes the Seperate BodyObject / BodySpriteRenderer, so the player has only 1 body in game.
/// (The Animation for Head and Body are seperate, but the Dead and Hurt animation requires the Head and Body to be combined.)
/// </summary>
public class PlayerLivesAnimator : MonoBehaviour {
	/*
	//Make ref to the separate Head Object
	private GameObject _head;
	//Make ref to the Player Animator;
	private Animator _animator;
	//Make a ref to the Player Status Script
	private PlayerStatus _state;

	// Use this for initialization
	void Start () {
		//Find the PlayerStatus Component
		_state = GetComponentInParent<PlayerStatus> ();
		//Find the Animator Component
		_animator = GetComponent<Animator> ();
		//Find the seperate Head
		_head = GameObject.FindGameObjectWithTag ("Head");
	}
	
	// Update is called once per frame
	void Update () {
		//Check when the Player is Dead or got Hurt
		CheckState ();
		//Animate the Player
		Animate ();
	}
		
	void CheckState(){
		//Check if the player is dead or if player is Hurt
		if (_state.getLiveState == 1 || _state.getLiveState == 2) {
			//Remove the seperate Head
			_head.SetActive (false);
		//Else if the player is neither
		} else if (_state.getLiveState == 0){
			//Readd the seperate Head
			_head.SetActive (true);
		}
	}
	void Animate(){
		//If the player is not "Alive"
		if (_state.getLiveState != 0){
			//Bring the next layer forwards
			_animator.SetLayerWeight (1,1);
			//Set the walking layer backwards
			_animator.SetLayerWeight (0,0);
			//Give the Animator the right value
			_animator.SetInteger ("liveState", _state.getLiveState);
		}
	}
	*/
}
