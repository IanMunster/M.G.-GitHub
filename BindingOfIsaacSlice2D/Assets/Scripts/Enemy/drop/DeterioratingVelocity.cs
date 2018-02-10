using UnityEngine;
using System.Collections;

public class DeterioratingVelocity : ConstantVelocity {

    [SerializeField] private float deceleration;
    [SerializeField] private bool isAllowingLowerThenZero;

    private float _currentSpeed;
    private float _startTime;

    void Awake()
    {
        _startTime = Time.time;
    }

    public Vector3 slowingVelocity {
        get { return Velocity(); }

    }

    public Vector3 Velocity()
    {
        Vector3 tempVelocity;
        tempVelocity = _direcrionvector;
        _currentSpeed = _speed - deceleration * (Time.time - _startTime);
        if (!isAllowingLowerThenZero && _currentSpeed < 0)
        {
            _currentSpeed = 0;
        }
        tempVelocity = _direcrionvector *  _currentSpeed;
        return tempVelocity;
    }
}
