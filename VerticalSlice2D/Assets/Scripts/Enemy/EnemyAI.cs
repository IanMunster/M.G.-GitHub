using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	private EnemyHealth _health; 
	private EnemyChasing _chase;
	private EnemyPatrolling _patrol;
    private EnemyMovement _movement;

	private Vector3 _newDirection;
	private bool _isChasing;
	private bool _isPatrolling;

	public Vector3 getDirection {
		get { return _newDirection;} 
	}

	// Use this for initialization
	void Start () {
		_health = GetComponent<EnemyHealth> ();
		_chase = GetComponent<EnemyChasing> ();
		_patrol = GetComponent<EnemyPatrolling> ();
        _movement = GetComponent<EnemyMovement>();
        _isPatrolling = true;//TEMP
	}
	
	// Update is called once per frame
	void Update () {
		_patrol.setIsPatrolling (_isPatrolling);
        _movement.Move(GetAllDirections());
	}

	Vector3 GetAllDirections(){
        return _patrol.getVelocity + _chase.getVelocity;
	}

    void OnCollisionEnter(Collision other)//TEMP
    {
        //_patrol.NewRandomVemocity();
        
    }
 }