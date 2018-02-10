using UnityEngine;
using System.Collections;

public class ProjectileInput : MonoBehaviour {

    [SerializeField]private InputHandler _input;
    private ProjectileMovement _movement;
    private float[] _shootSides = new float[2];

    void Start()
    {
        _movement = GetComponent<ProjectileMovement>();
        InputTranselate();
        //_movement.SetMovement(_shootSides[0],_shootSides[1] );

    }

    void InputTranselate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _shootSides[0] = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _shootSides[0] = 1;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            _shootSides[1] = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            _shootSides[1] = -1;
        }
        else
        {

        }
    }
	
    
}
