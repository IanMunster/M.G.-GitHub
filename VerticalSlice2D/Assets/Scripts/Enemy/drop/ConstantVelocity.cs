using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ConstantVelocity : MonoBehaviour {
    public enum direction
    {
        Up,
        Down,
        Left,
        Right
    };

    [SerializeField] private direction _direction;
    [SerializeField] protected float _speed;

    protected Vector3 _direcrionvector;
    private Vector3 _velocity;

    private Dictionary<direction, Vector3> _directions;

    public Vector3 velocity
    {
        get { return _direcrionvector * _speed; }
    }

	// Use this for initialization
	void Start () {
        _directions = new Dictionary<direction, Vector3> {
            {direction.Up,  new Vector3(0, 1)},
            {direction.Down, new Vector3(0, -1)},
            {direction.Right, new Vector3(1, 0) },
            {direction.Left, new Vector3(-1, 0) }
        };
        _direcrionvector = _directions[_direction];

    }
	
    public void SetNewDirection()
    {
        _direcrionvector = _directions[_direction];
    }
}
