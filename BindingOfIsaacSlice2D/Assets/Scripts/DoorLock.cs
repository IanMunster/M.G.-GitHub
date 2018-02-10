using UnityEngine;
using System.Collections;

public class DoorLock : MonoBehaviour {

	[SerializeField] private bool isLocked;
	private Animator _animator;
	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(isLocked){
			_animator.SetLayerWeight (0,0);
			_animator.SetLayerWeight (1,1);
		}
	}
}
