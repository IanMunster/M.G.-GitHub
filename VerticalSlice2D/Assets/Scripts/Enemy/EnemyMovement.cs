using UnityEngine;
using System.Collections;
/// <summary>
/// Enemy movement.
/// This Class is responsible for moving the EnemyObject.
/// It derives its Direction from the EnemyAI component, 
/// which in its turn derives the AI-status from the Chasing and Patrolling Components
/// </summary>
public class EnemyMovement : MonoBehaviour {

	private EnemyAI _ai;
	private Vector3 _direction;
	private Vector3 _velocity;
	[SerializeField] private float _speed;

	public float getSpeed {
		get{ return _speed; }
	}

	public float setSpeed (float _newSpeed){
		return _speed = _newSpeed;
	}

    public void Move(Vector3 velocity)
    {
        _velocity = velocity;
        _velocity.Normalize();
        _velocity *= _speed;
        transform.position += _velocity * Time.deltaTime;
    }

	public Vector3 getVelocity{
		get{return _velocity; }
	}

	// Use this for initialization
	void Start () {
		_ai = GetComponent<EnemyAI> ();
	}
}
