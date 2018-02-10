using UnityEngine;
using System.Collections;
/// <summary>
/// Shoot handler.
/// </summary>
public class ShootHandler : MonoBehaviour {

	[SerializeField] private GameObject _projectile;
	private Vector3 _shotDirection;

	public Vector3 Direction{
		get{ return _shotDirection; }
		set{ _shotDirection = value; }
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setShootDirection(Vector3 newDirection){
		_shotDirection = newDirection;
	}
}
