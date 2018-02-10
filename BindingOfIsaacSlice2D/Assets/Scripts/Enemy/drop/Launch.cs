using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Launch : MonoBehaviour {
    public enum direction
    {
        Up,
        Down,
        Left,
        Right
    };

    [SerializeField] private direction _direction;
    [SerializeField] private float _startSpeed;
    [SerializeField] private float _randomSideRangeLeft;
    [SerializeField] private float _randomSideRangeRight;
    [SerializeField] private float _deceleration;

    private float _currentSpeed;
    private Vector3 _direcrionvector;
    private Vector3 _velocity;
    private Vector3 randomSide;

    private Dictionary<direction, Vector3> _directions;

	// Use this for initialization
	void Start () {
        _directions = new Dictionary<direction, Vector3> {
            {direction.Up,  new Vector3(0, 1)},
            {direction.Down, new Vector3(0, -1)},
            {direction.Right, new Vector3(1, 0) },
            {direction.Left, new Vector3(-1, 0) }
        };
        _direcrionvector = _directions[_direction];
        

        _currentSpeed = _startSpeed;

        if (_direction == direction.Up || _direction == direction.Down)
        {
            randomSide = new Vector3(Random.Range(-_randomSideRangeLeft, _randomSideRangeRight), 0);
        }
        else
        {
            randomSide = new Vector3(0, Random.Range(-_randomSideRangeLeft, _randomSideRangeRight));
        }
    }
	
	// Update is called once per frame
	void Update () {
        

        _currentSpeed -= _deceleration;
        if(_currentSpeed < 0)
        {
            _currentSpeed = 0;
        }
        _velocity = _direcrionvector * _currentSpeed + randomSide;
        transform.position += _velocity;
	}
}
