using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Makes the input usable for shooting
/// </summary>
public class WeaponsInputProcessor : MonoBehaviour {

    private MethodRepeater _repeater;

    private Vector2 _shootDirection;
    public Vector3 shootDirection
    {
        get { return _shootDirection; }
    }
    
    void Start()
    {
        _repeater = GetComponent<MethodRepeater>();
    }


    void Update()
    {
        if(_shootDirection.magnitude > 0)
        {
            _repeater.isActive = true;
        }
        else
        {
            _repeater.isActive = false;
        }
    }

    public void setShooting(Vector3 shoot)
    {
        _shootDirection = shoot;
    }
}
