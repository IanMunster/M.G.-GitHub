using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Class that takes all the info from the other scripts and uses it.
/// </summary>
public class ShootSwitched : MonoBehaviour {

    [SerializeField] private PositionSwitch[] _positionSwitch;//the script that switches the positions of the weapons
    [SerializeField] private int PlayerLayer;//the numer the player is in the order of the layer it is in

    private TriggerComponentHolder _triggers;//the scripts that can shoot a projectile.
    private WeaponsInputProcessor _input;//the prossesed input
    private Vector2 _direction;
    private Switch _switch;//a number switch

    void Start()
    {
        _switch = new Switch();//makes a new switch
        _switch.maxNum = _positionSwitch.Length-1;//max the max num of the switch 2
        _triggers = GetComponent<TriggerComponentHolder>();
        _input = GetComponent<WeaponsInputProcessor>();
    }

    void Update()
    {    
        _direction = _input.shootDirection;//gets the direction
    }

    public void Shoot()
    { 
        Shoot trigger = _triggers.triggers[_switch.currentNum];//the current trigger
        if(_direction.x != 0)
        {

            SwitchAllWeaponPositions(1);
            trigger.ShootWeapon(_switch.currentNum * (PlayerLayer + 1), _direction);
        }
        else if(_direction.y != 0)
        {

            SwitchAllWeaponPositions(0);
            if(_direction.y > 0)
            {
                trigger.ShootWeapon(PlayerLayer-1, _direction);
            }
            else
            {
                trigger.ShootWeapon(PlayerLayer +1, _direction);
            }
        }

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

    
}
