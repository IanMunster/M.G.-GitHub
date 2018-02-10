using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class EnemyInGame : MonoBehaviour {

	private int totalEnemys;
	//private int killedEnemys;

	public Text enemysToKill;
	public Text centerTxt;

	// Use this for initialization
	void Start () {
		//killedEnemys = 0;
		//updateUI ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		GameObject[] EnemyPack = GameObject.FindGameObjectsWithTag ("Enemy");
		totalEnemys = EnemyPack.Length;
		updateUI ();

		if (totalEnemys <= 0){
			centerTxt.text = "You've Won! press spacebar to try again";
			if(Input.GetKeyDown("space")){
				SceneManager.LoadScene ("TDShooter1");
			}
		}
	}

	void updateUI(){
		enemysToKill.text = "Enemy's left: "+ totalEnemys.ToString () +"";
	}
}