using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Class that takes all the info of the other scripts and uses it.
/// </summary>
public class ShootSwitched : MonoBehaviour {


    private Dictionary<directions, bool> _direction;

    private Dictionary<directions, Vector2> _directionVectors = new Dictionary<directions, Vector2>
    {
        {directions.Up, new Vector2(0, 1) },
        {directions.Down, new Vector2(0, -1) },
        {directions.Left, new Vector2(-1, 0) },
        {directions.Right, new Vector2(1, 0) }
    };

    
    
    [SerializeField] private TriggerComponentHolder _triggers;//the scripts that can shoot a projectile.
    [SerializeField] private WeaponsInputProcessor _input;//the prossesed input
    [SerializeField] private PositionSwitch[] _positionSwitch;//the script that switches the positions of the weapons
    [SerializeField] private int PlayerLayer;//the numer the player is in the order of the layer it is in

    private Switch _switch;//a number switch

    void Start()
    {
        _switch = new Switch();//makes a new switch
        _switch.maxNum = 2;//max the max num of the switch 2
    }

    void Update()
    {    
        _direction = _input.direction;//gets the direction
    }

    public void Shoot()
    { 
        Shoot trigger = _triggers.triggers[_switch.currentNum];//the current trigger
        if (_direction[directions.Down])//if the direcition (the player is looking at) is down
        {
            SwitchAllWeaponPositions(0);//sets the position at position 0
            trigger.ShootWeapon(2, _directionVectors[directions.Down]);
        }
        if (_direction[directions.Left])//if the direcition (the player is looking at) is Left
        {
            SwitchAllWeaponPositions(1);//sets the position at position 1
            trigger.ShootWeapon(_switch.currentNum*2, new Vector2(-1, 0));
        }
        if (_direction[directions.Right])//if the direcition (the player is looking at) is Right
        {
            SwitchAllWeaponPositions(1);//sets the position at position 1
            trigger.ShootWeapon(_switch.currentNum * 2, new Vector2(1, 0));
        }
        if (_direction[directions.Up])//if the direcition (the player is looking at) is Up
        {
            SwitchAllWeaponPositions(0);//sets the position at position 0
            trigger.ShootWeapon(0, new Vector2(0, 1));
        }

        /*foreach(KeyValuePair<directions, bool> pair in _direction)
        {
            if (pair.Value)
            {
                SShoot(2, pair.Key);
            }
        }*/

        _switch.NextNum();//selects the bext num in the numberSwitch
    }

    /// <summary>
    /// changes the position of all the weapons
    /// </summary>
    /// <param name="pos">the number of the position</param>
    void SwitchAllWeaponPositions(int pos)
    {
        for(int i = 0; i < _positionSwitch.Length; i++)
        {
            _positionSwitch[i].SwitchPosition(pos);
           
        }
    }

    void SShoot(int pos, directions richting)
    {
        int layer = 0;

        if(_direction[directions.Right] || _direction[directions.Left])
        {
            layer = _switch.currentNum * 2;
            SwitchAllWeaponPositions(1);
        }
        else if (_direction[directions.Down])
        {
            layer = 2;
            SwitchAllWeaponPositions(0);
        }
        else
        {
            SwitchAllWeaponPositions(0);
        }
        Shoot trigger = _triggers.triggers[_switch.currentNum];
        //SwitchAllWeaponPositions(1);//sets the position at position 0
        trigger.ShootWeapon(0, _directionVectors[richting]);
    }

    
}
