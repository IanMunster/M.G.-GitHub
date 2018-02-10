using UnityEngine;
using System.Collections;
/// <summary>
/// Player movement audio.
/// </summary>
public class PlayerMovementAudio : MonoBehaviour {
	/*
	[SerializeField] private AudioClip[] _walkAudio;
	private AudioSource _walkSource;

	private PlayerStatus _status;
	private int _randomizer;
	private bool _isPlaying;

	// Use this for initialization
	void Start () {
		_walkSource = GetComponent<AudioSource> ();
		_status = GetComponentInParent<PlayerStatus> ();
	}
	
	// Update is called once per frame
	void Update () {
		PlaySound ();
	}

	void PlaySound (){

		if(_status.getMovementState > 0){
			_walkSource.Play ();
		} else if(_status.getMovementState == 0 && _walkSource.isPlaying){
			_walkSource.Stop ();
		}
		if(!_walkSource.isPlaying){
			_randomizer = Random.Range (0,_walkAudio.Length);
			_walkSource.clip = _walkAudio [_randomizer];
		}
	}
	*/
}
