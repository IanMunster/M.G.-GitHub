using UnityEngine;
using System.Collections;

public class EnemyChasing : MonoBehaviour {


	private bool _isChasing;
	private GameObject _target;
	private Vector3 _velocity;
    [SerializeField] private string _targetName;

    public Vector3 getVelocity
    {
        get { return _velocity; }
    }


	public bool setIsChasing(bool newOrders){
		_isChasing = newOrders;
        StartCoroutine(CalculateNewVelocity());
		return newOrders;
	}

    void Start()
    {
        _target = GameObject.Find(_targetName);

    }

    IEnumerator CalculateNewVelocity()
    {
        while (true)
        {
            Vector3 targetPos = _target.transform.position;
            _velocity = targetPos - transform.position;
            yield return null;
        }

    }

	
}
