using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// All directions.
/// </summary>
public enum directions
{
    Up,
    Down,
    Left,
    Right
};

/// <summary>
/// Makes the input usable for shooting
/// </summary>
public class WeaponsInputProcessor : MonoBehaviour {

    private Dictionary<directions, bool> _direction;//the dictionary of the directions
    private bool _isShooting;//if the player is shooting

    [SerializeField] private PlayerStatus _state;//the input script
    [SerializeField] private ShootSwitched _shootDir;//controller script
    [SerializeField] private MethodRepeater _repeater;//the script that repeates the method set is the inspector

    public Dictionary<directions, bool> direction
    {
        get { return _direction; }
    }

    public bool isShooting
    {
        get { return _isShooting; }
    }

    void Start()
    {
        NewDirectionDic();
    }

    void Update()
    {
        int lookState = _state.getLookState;//the lookstate
        int movestate = _state.getMovementState;//the movement state
        bool shootstate = _state.getShootState;//the shootstate

        if (lookState != 0)//if a look key is pressed
        {
            CheckInput(lookState);//sets the shooting side to the pressed key.
        }
        else
        {
            CheckInput(movestate);//sets the shooting side to the last pressed movement key.
        }

        if (shootstate)//if the swooring key is pressed
        {
            Shooting(true);//start shooting
        }
        else//else
        {
            Shooting(false);//stop shooting
        }
    }

    //checks and sets the input.
    private void CheckInput(int lookState)
    {
        if (lookState == 1)
        {
            setDirection(directions.Up);
        }
        if (lookState == 3)
        {
            setDirection(directions.Down);
        }
        if (lookState == 2)
        {
            setDirection(directions.Right);
        }
        if (lookState == 4)
        {
            setDirection(directions.Left);
        }
    }
    /// <summary>
    /// Turns on and off if the player is shooting.
    /// </summary>
    /// <param name="isShooting">Is the player shooting</param>
    private void Shooting(bool isShooting)
    {
        _isShooting = isShooting;
        _repeater.isActive = isShooting;

    }
    /// <summary>
    /// sets a new direction
    /// </summary>
    /// <param name="dir">the direcion that is true</param>
    public void setDirection(directions dir)
    {
        ResetDirectionDic();
        _direction[dir] = true;

    }

    /// <summary>
    /// makes all the directions false
    /// </summary>
    private void ResetDirectionDic()
    {
        _direction[directions.Up] = false;
        _direction[directions.Right] = false;
        _direction[directions.Left] = false;
        _direction[directions.Down] = false;
    }

    /// <summary>
    /// creates a new dictionary.
    /// </summary>
    private void NewDirectionDic()
    {
        _direction = new Dictionary<directions, bool>();
        _direction.Clear();
        ResetDirectionDic();
    }
}
