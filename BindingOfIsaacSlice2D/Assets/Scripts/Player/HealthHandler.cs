using UnityEngine;
using System.Collections;
/// <summary>
/// Health handler.
/// This Class is responible for all the Health the and Getting Damage
/// </summary>
public class HealthHandler : MonoBehaviour {

	[SerializeField] private int _maxHealth;		//Total Maximal Health
	private int _minHealth;
	private int _currentHealth;						//The value of the Current Health
	private bool _isDead;							//Boolean when health = 0 a.ka Dead

	// Use this for initialization
	void Start () {									//On Start of Game
		_currentHealth = _maxHealth;				//Set the Current Health to Max
		_minHealth = 0;
		_isDead = false;
	}
	// Update is called once per frame
	void Update () {	//Continues to Update per frame
		if(_currentHealth < _minHealth){			//When the Current Health is smaller than 0
			_isDead = true;							//Is dead is true
			_currentHealth = _minHealth;
		} else {		
			_isDead = false;						//Else Is dead is false
		}

		if(_currentHealth > _maxHealth){			//If Current health is more than max Health
			_currentHealth = _maxHealth;			//Current Health is max Health
		}
	}

	public int getCurrentHealth{					//Get the Current Health
		get{ return _currentHealth; }				//Return Int CurrentHealth
	}

	public bool getIsDead{							//Get is Dead
		get{ return _isDead; }						//Return Boolean isDead
	}

	public void setNewHealth(int _newHealth){		//Set new Health value
		_currentHealth = _newHealth;				//Set Currenthealth to new Health value;
	}

	public void subtractHealth(int _damage){		//Set the Damage to Health
		//StartCoroutine?
		_currentHealth -= _damage;				//Subtract Damage from Current Health
	}
}
