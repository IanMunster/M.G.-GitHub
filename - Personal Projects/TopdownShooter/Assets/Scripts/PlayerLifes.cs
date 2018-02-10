using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerLifes : MonoBehaviour {

	public float Lifes = 100;
	public Text HealthUI;
	public Text centerText;
	public float HealthPickUp;
	private float AttackTimer = 0.0F;
	private float DelayTimer = 1F;

	void Start(){
		centerText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
	
		updateUI ();
		if(Lifes <= 0 || Lifes < 1) {
			restartLevel ();
		}

		if(Lifes > 100){
			Lifes = 100;
		}
		if(Lifes < 0){
			Lifes = 0;
		}
	}
	void updateUI(){
		HealthUI.text = "Health: " + Lifes + "";
	}

	void OnTriggerStay(Collider other){
		//Debug.Log ("Hit a Player");
		if (other.CompareTag ("Enemy")) {
			if (Time.time > AttackTimer) {
				
				TakeDmg ();
				AttackTimer = Time.time + DelayTimer;
			}
		}
		//if (other.gameObject.CompareTag ("Health")) {
		//	Lifes += HealthPickUp;
		//	Destroy (other.gameObject);
		//}
	}

	void TakeDmg(){
		float DMG = Random.Range (1, 10);
		Lifes -= DMG;
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.CompareTag ("Health")) {
			//Debug.Log ("HELP!");
			Lifes += HealthPickUp;
			Destroy (other.gameObject);
		}
	}

	void restartLevel (){
		centerText.text = "You've LOST! press spacebar to try again";
		if(Input.GetKeyDown("space")){
			SceneManager.LoadScene ("TDShooter1");
		}

	}

}
