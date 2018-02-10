using UnityEngine;
using System.Collections;

/// <summary>
/// sets the saved positions of the PositionSwitch
/// </summary>
public class PositionSwitchSetter : MonoBehaviour {

    private PositionSwitch _switch;//the position switch
    [SerializeField]private Transform _pos2;//the second position

    void Start()
    {
        _switch = GetComponent<PositionSwitch>();//gets the position switch
        _switch.SetPositionOne(this.transform.localPosition);//sets the first position
        _switch.SetPositionTwo(_pos2.localPosition);//sets the second position
    }
}
