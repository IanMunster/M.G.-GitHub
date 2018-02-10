using UnityEngine;
using System.Collections;
/// <summary>
/// Projectile movement.
/// Moves the Projectile in the current Vertical or Horizontal rotation * the given Speed.
/// Stops the Projectile if it Collider Triggers with an other Collider, but ignores the given Ignore Collider string (tag)
/// </summary>
public class ProjectileMovement : MonoBehaviour {

    [SerializeField] private float _projectileSpeed;
	[SerializeField] private string _ignoreCollider;
    private float _movementHorizontal;
    private float _movementVertical;
    private Vector3 _direction;

	void Update () {
        transform.position += _direction * Time.deltaTime;

	}

    public void SetMovement(Vector2 dir)
    {
        _direction = dir;
        _direction.Normalize();
        _direction *= _projectileSpeed;
        //_direction = new Vector2(_projectileSpeed * horizontal, _projectileSpeed * vertical);
    }
    
	//Stops the projectile to play "Hit" animations
	void OnColliderEnter(Collider other){
		//Do not stop if collides with Ignored Objects or if there is no given Ignore string
		print("COLLIDER TAG: "+other.GetComponent<Collider>().tag);
		if (!other.GetComponent<Collider>().CompareTag (_ignoreCollider)) {
			_projectileSpeed = 0;
			_movementHorizontal = 0;
			_movementVertical = 0;
		}
	}
}
