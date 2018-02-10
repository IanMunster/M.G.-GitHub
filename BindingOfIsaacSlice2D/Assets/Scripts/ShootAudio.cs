using UnityEngine;
using System.Collections;

public class ShootAudio : MonoBehaviour {

	[SerializeField] private AudioClip _clip;
	private AudioSource _source;

	public void PlayAudio(){
		_source.PlayOneShot (_clip);
	}


	// Use this for initialization
	void Start () {
		_source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
