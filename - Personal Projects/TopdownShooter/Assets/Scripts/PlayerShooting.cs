using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	public Projectile projectile; 	//De Bullets
	public Text ammoUI;
	public Text bulletUI;
	public Transform muzzle;		//Muzzle punt vd Gun
	public float bulletSpeed;		//Snelheid vd Bullets


	public float fireRate = 1f;		//Zorg voor x Aantal bullet per Seconde
	public float bullets = 31f;		//Aantal Kogels Max

	public float reloadTime = 1f;		//Herlaad tijd
	public float shootDelay = 0.1f;		//Schotdelay voor Herlaad

	private float nextFire = 0f;	//Zorg voor x Aantal bullet per Seconde
	private float shotTimer = 0f;	//Schot timer voor Herlaad
	private float ammoLeft = 3;	//Hoeveel Ammo (TotaalBullets=(ammo x bullets))


	void Update() {
		if (Input.GetMouseButton (0) && bullets > 0 && Time.time > shotTimer && Time.time > nextFire) {
			Shoot ();							//schietfunctie
			shotTimer = Time.time + shootDelay; //shiet timer voor volgende shot
		}
		if (Input.GetKeyDown("r") && bullets == 0 && ammoLeft > 0) {
			Debug.Log ("RELOADING!");
			bullets += 31;
			ammoLeft -= 1;
			shotTimer = Time.time + reloadTime;
		}
		updateUI ();
	}

	void Shoot() {
		bullets -= 1;
		Projectile bullet = Instantiate (projectile, muzzle.position, muzzle.rotation) as Projectile;
		bullet.SetSpeed (bulletSpeed);
		nextFire = Time.time + fireRate; //Zorg voor x Aantal bullet per Seconde
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.CompareTag ("Ammo")) {
			ammoLeft += 1;
			Destroy (other.gameObject);
		}
	}

	void updateUI(){
		bulletUI.text = "Bullets: "+bullets+" /31";
		ammoUI.text = "Ammo: " + ammoLeft + "";
	}
}