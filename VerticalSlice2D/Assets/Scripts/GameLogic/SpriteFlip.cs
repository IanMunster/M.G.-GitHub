using UnityEngine;
using System.Collections;

/// <summary>
/// Sprite flip.
/// This script is responsible for flipping the Sprite of the Player (Horizontal)
/// </summary>

public class SpriteFlip : MonoBehaviour {

	//ref to the input handler for movement
	private InputHandler _input;
	//boolean is the sprited flipped?
	private bool _isFlipped = true;
	//Extra option for Head Sprite
	[SerializeField] private bool _isHead;

	// Use this for initialization
	void Start () {
		//Get the InputHandler component in the GameController object
		_input = GameObject.FindGameObjectWithTag ("GameController").GetComponent<InputHandler> ();
		if(_input == null){
			print ("NO GAME CONTROLLER DETECTED");
		}
	}
	
	// Update is called once per frame
	void Update () {

		CheckMovement ();
		CheckLooking ();

	}

	void CheckMovement(){
		//When the horizontal input is bigger than 0 and the sprite is not flipped
		if (_input.moveHorizontal > 0  && !_isFlipped){
			//flip the Sprite
			FlipSprite ();
			//Else when the horizontal input is smaller than 0 and the sprite is flipped
		} else if(_input.moveHorizontal < 0 && _isFlipped){
			//flip the sprite
			FlipSprite ();
		}
	}

	void CheckLooking(){
		//When the horizontal input is bigger than 0 and the sprite is not flipped
		if (_input.lookHorizontal > 0  && !_isFlipped && _isHead){
			//flip the Sprite
			FlipSprite ();
			//Else when the horizontal input is smaller than 0 and the sprite is flipped
		} else if(_input.lookHorizontal < 0 && _isFlipped && _isHead){
			//flip the sprite
			FlipSprite ();
		}
	}

	void FlipSprite (){
		//the sprite flip is not flipped
		_isFlipped = !_isFlipped;
		//get the localscaling of the Sprite
		Vector3 tempScale = transform.localScale;
		//flip the localscaling in temp var
		tempScale.x *= -1;
		//give the localscale the value of the temp var
		transform.localScale = tempScale;
	}
}
