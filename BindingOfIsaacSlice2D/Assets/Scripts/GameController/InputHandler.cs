using UnityEngine;
using System.Collections;
/// <summary>
/// This script is responsible for managing the user input.
/// Requires the Unity Input manager to be changed: The Secondair Axis need to be a seperate Axis called "LookVertical" and "LookHorizontal"
/// </summary>
public class InputHandler : MonoBehaviour {

    //Returns the value "Horizontal" axis of "A" & "D" keys.
    public float moveHorizontal { 
        get { return Input.GetAxisRaw ("Horizontal"); }
    }
    //Returns the value "Vertical" axis of "W" & "S" keys.
    public float moveVertical {
		get { return Input.GetAxisRaw ("Vertical"); }
    }
	//Returns the value "Horizontal" axis of "Up" & "Down" arrows.
	public float lookHorizontal {
		get { return Input.GetAxisRaw ("LookHorizontal"); }
	}
	//Returns the value "Vertical" axis of "Left" & "Right" arrows.
	public float lookVertical {
		get { return Input.GetAxisRaw ("LookVertical"); }
	}
}
