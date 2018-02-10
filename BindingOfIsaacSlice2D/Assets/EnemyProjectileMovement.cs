using UnityEngine;
using System.Collections;

public class EnemyProjectileMovement : MonoBehaviour {

    private Vector3 _velocity;
    private Vector3 _targetPosition;
    
    [SerializeField] private float _randomRange;
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _target;
    [SerializeField] private string _targetName;

    public Vector3 getVelocity
    {
        get { return _velocity; }
    }
    
	// Use this for initialization
	void Start () {
        if(_target == null)
        {
            _target = GameObject.Find(_targetName);
        }
        _targetPosition = _target.transform.position;
        Vector3 temp = new Vector3(Random.Range(0,_randomRange), Random.Range(0, _randomRange), 0);
        _targetPosition += temp;
        _velocity = _targetPosition - transform.position;
        _velocity.Normalize();
        _velocity *= _speed;
        StartCoroutine(Move());
	}
	
	// Update is called once per frame
	void Update () {
      //  transform.position += _velocity;
    }

    void OnCollisionEnter(Collision col)
    {
        print("k cool");
    }
    private IEnumerator Move()
    {
        while((transform.position-_targetPosition).magnitude > 0.1)
        {
            transform.position += _velocity;
            yield return null;
        }
    }
}
