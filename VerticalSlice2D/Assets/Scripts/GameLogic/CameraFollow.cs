using UnityEngine;
using System.Collections;
/// <summary>
/// Camera follow.
/// This Class is responible for the Main Camera's position. It makes the Camera follow the Target
/// </summary>
public class CameraFollow : MonoBehaviour {
	[SerializeField] private string _targetName;
	//Gameobject for the chosen Target the Camera has to follow
	private GameObject _target;
	//The Main Camera in the scene
	private Camera _main;
	//The Vector3 of the offset distance between the Target and the Camera
	private Vector3 _offset;



	// Use this for initialization
	void Start () {
		_target = GameObject.Find (_targetName);
		//Set the main var to the Current Main Camera
		_main = Camera.main;
		//Set the offset by subtracting the Targets position from the Camera's position 
		_offset = _main.transform.position - _target.transform.position;
	}
	
	// LateUpdate is called after each frame
	void LateUpdate () {
		//Set the position of the main camera to the Targets position
		_main.transform.position = _target.transform.position + _offset;
	}
}
