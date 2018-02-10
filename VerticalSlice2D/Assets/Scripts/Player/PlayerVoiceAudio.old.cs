using UnityEngine;
using System.Collections;
/// <summary>
/// Player voice audio.
/// </summary>
public class PlayerVoiceAudio : MonoBehaviour {
	/*
	[SerializeField] private AudioClip[] _hurtAudio;
	[SerializeField] private AudioClip _deadAudio;
	private AudioSource _voiceSource;
	private PlayerStatus _status;
	private bool _isPlaying;
	private int _randomizer;
	// Use this for initialization
	void Start () {
		_status = GetComponent<PlayerStatus> ();
		_voiceSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(_status.getLiveState == 2){
			print ("Play DeadSound");
			_voiceSource.clip = _deadAudio;
			_voiceSource.Play ();
			//_voiceSource.SetScheduledEndTime (_voiceSource.time);
		}
		if(_status.getLiveState == 1){
			print ("Play HitSound");
			_voiceSource.clip = _hurtAudio [_randomizer];
			_voiceSource.Play ();
			//_voiceSource.SetScheduledEndTime (_voiceSource.time);
		}
	}
	*/
}
