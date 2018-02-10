using UnityEngine;
using System.Collections;

public class tempAI : MonoBehaviour {

    private EnemyHealth _health;
    private EnemyChasing _chase;
    private EnemyPatrolling _patrol;

    private Vector3 _newDirection;
    private bool _isChasing;
    private bool _isPatrolling;

    public Vector3 getDirection
    {
        get { return _newDirection; }
    }

    // Use this for initialization
    void Start()
    {
        _health = GetComponent<EnemyHealth>();
        _chase = GetComponent<EnemyChasing>();
        _patrol = GetComponent<EnemyPatrolling>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckPriority();
        _patrol.setIsPatrolling(_isPatrolling);
        //_newDirection = CheckDirections ();
    }

    void CheckPriority()
    {
        print("CHECK: isChasing " + _isChasing);
        if (_health.getIsHit)
        {
            _isChasing = true;
            _isPatrolling = false;
        }
        else {
            _isChasing = false;
            _isPatrolling = true;
            _patrol.setIsPatrolling(true);
        }

    }

    /*Vector3 CheckDirections(){
		print ("CHECK: Directions "+_newDirection);
		if (_isChasing) {
			return _chase.getTarget;
		} else if (!_isChasing) {
			return _patrol.getTarget;
		} else {
			return new Vector3 (0f,0f,0f);
		}
	}*/
}
