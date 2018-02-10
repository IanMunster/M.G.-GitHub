using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// have to change -,-
/// </summary>
public class ShootInputs : MonoBehaviour {

    private InputHandler _input;
    private PositionSwitch _posSwitch;

	void Start(){
		//_input = GameObject.Find("GameController").GetComponent<InputHandler> ();
		_posSwitch = GetComponentInParent<PositionSwitch> ();;
	}

	void Update()
    { 
		/*if(_input.lookVertical < -0.01 || _input.lookVertical > 0.01)
        {
			_posSwitch.SwitchPosition(0);
        }
		if (_input.lookHorizontal < -0.01 || _input.lookHorizontal > 0.01)
        {
			_posSwitch.SwitchPosition(1);
        }*/

    }

}
