using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

    [SerializeField] private float _gravityForce;

    private Vector3 _gravity;
    
    public Vector3 gravity
    {
        get { return _gravity; }
    } 

    public float gravityForce
    {
        get { return _gravityForce; }
        set { _gravityForce = value; }
    }

    void Start()
    {
        SetGravity();
    }

    void SetGravity()
    {
        _gravity = new Vector3(0, -_gravityForce, 0);
    }

}
