using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameSceneManager : MonoBehaviour {

	private PlayerLives _PlayerLives;

	// Use this for initialization
	void Start () {
		_PlayerLives = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerLives> ();
		if(_PlayerLives == null){
			print ("No PlayerLives Detected in Scene @SceneManager");
		}
	}

	// Update is called once per physics step
	void FixedUpdate () {
		CheckForGameOver ();
	}

	void CheckForGameOver (){
//		if(_PlayerLives.getIsDead){
//			new WaitForSeconds (10f);
//		//	SceneManager.LoadScene (0);
//		}
	}

}
