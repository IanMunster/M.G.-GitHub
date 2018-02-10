using UnityEngine;
using System.Collections;

public class EnemyPatrolling : MonoBehaviour {

    private Vector3 _velocity;
    private bool _isPatrolling;
    private Vector3 _currentPos;
	//X = Min time, Y= Max time
	[SerializeField] Vector2 _timeBeforeRedirect;
    [SerializeField] float _randomWalkrange;

    public Vector3 getVelocity
    {
        get { return _velocity; }
    }
	
    void Start()
    {
		StartCoroutine(Patrol());
    }

    public void setIsPatrolling(bool newOrders){ 
		_isPatrolling = newOrders;
        if (!newOrders) {
			_velocity = new Vector3(0, 0, 0);
		}
    }


    IEnumerator Patrol() { 
		while (!_isPatrolling) {
			_velocity = new Vector3(0, 0, 0);
			yield return null;NewRandomVemocity();
			yield return new WaitForSeconds(Random.Range(_timeBeforeRedirect.x, _timeBeforeRedirect.y));
		}
    }

    public void NewRandomVemocity(){
		_velocity = new Vector3(Random.Range(-_randomWalkrange, _randomWalkrange), Random.Range(-_randomWalkrange, _randomWalkrange), 0);
		_velocity.Normalize();
    }
}
