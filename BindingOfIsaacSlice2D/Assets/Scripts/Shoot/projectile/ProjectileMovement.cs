using UnityEngine;
using System.Collections;
/// <summary>
/// Projectile movement.
/// Moves the Projectile in the current Vertical or Horizontal rotation * the given Speed.
/// Stops the Projectile if it Collider Triggers with an other Collider, but ignores the given Ignore Collider string (tag)
/// </summary>
public class ProjectileMovement : MonoBehaviour {

    [SerializeField] private float _projectileSpeed;
    private Vector3 _direction;
    private Vector3 _velocity;
	private Rigidbody _rigid;

    public Vector3 Velocity {
        get { return _velocity; }
		set { _velocity = value; }
    }

	public Vector3 Movement{
		get{ return _direction; }
		set{ _direction = value; }
	}

    void Start()
    {
        _rigid = GetComponent<Rigidbody>();
		Move ();
    }

	void Update () {
		//transform.position += _direction * Time.deltaTime;
	}

	void Move(){
		_direction.Normalize();
		_velocity = _direction * _projectileSpeed;
		_rigid.velocity = _velocity;
	}
}
