using UnityEngine;
using System.Collections;
/// <summary>
/// Health handler.
/// </summary>
public class HealthHandler : MonoBehaviour {

	[SerializeField] private int _maxHealth;
	private int _currentHealth;
	private bool _isDead;

	// Use this for initialization
	void Start () {
		_currentHealth = _maxHealth;
	}
	// Update is called once per frame
	void Update () {
		if(_currentHealth == 0){
			_isDead = true;
		}
		_isDead = false;
	}
	//
	public int getCurrentHealth{
		get{ return _currentHealth; }
	}
	//
	public bool getIsDead{
		get{ return _isDead; }
	}
	//
	public void setNewHealth(int _newHealth){
		_currentHealth = _newHealth;
	}
	//
	public void subtractHealth(int _damage){
		//StartCoroutine?
		//_currentHealth -= _damage;
	}
}
