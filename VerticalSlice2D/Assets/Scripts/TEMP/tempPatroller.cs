using UnityEngine;
using System.Collections;

public class tempPatroller : MonoBehaviour {

    private bool _isPatrolling;
    private bool _onTarget;
    private Vector3 _target;
    private Vector3 _newTarget;
    private Vector3 _currentPosition;

    public Vector3 getTarget
    {
        get { return _target; }
    }

    public bool setIsPatrolling(bool newOrders)
    {
        _isPatrolling = newOrders;
        return newOrders;
    }

    // Use this for initialization
    void Start()
    {
        StartCoroutine("Patrol");
        /*		if (_newTarget == null) {
                    print ("No Targets Found!");
                } else {
                    _target = _newTarget;
                } */
    }

    // Update is called once per frame
    void Update()
    {
        PatrolActivate();
        CheckTargetReached();
    }

    void PatrolActivate()
    {
        if (_isPatrolling)
        {
            StartCoroutine("Patrol");
        }
        else {
            StopCoroutine("Patrol");
        }
    }

    void CheckTargetReached()
    {
        if (_currentPosition.x == _target.x || _currentPosition.y == _target.y)
        {
            _onTarget = true;
        }
        _onTarget = false;
    }

    IEnumerator Patrol()
    {
        _currentPosition = this.transform.position;
        if (_currentPosition.x < _target.x)
        {
            _newTarget = new Vector3(3f, 0f, 0f);
        }
        else if (_currentPosition.x > _target.x)
        {
            _newTarget = new Vector3(-3f, 0f, 0f);
        }
        else if (_currentPosition.y < _target.y)
        {
            _newTarget = new Vector3(0f, 3f, 0f);
        }
        else if (_currentPosition.y > _target.y)
        {
            _newTarget = new Vector3(0f, -3f, 0f);
        }
        if (!_onTarget)
        {
            yield return null;
        }
        yield return new WaitForSeconds(5f);
    }
}
