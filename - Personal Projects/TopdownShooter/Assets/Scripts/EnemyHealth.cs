using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public float Lives = 100;
	public TextMesh enemyHealthUI;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		updateUI ();
		if (Lives <= 1 || Lives < 0) {
			Destroy (gameObject);
			enemyHealthUI.text = "";
		}
	}

	void updateUI(){
		enemyHealthUI.text = Lives + " %";
	}


	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Projectile")) {
			float DMG = Random.Range (10, 20);
			Lives = Lives - DMG;
		}
	}

}